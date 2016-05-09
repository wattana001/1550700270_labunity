using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CheckAmmo : MonoBehaviour
{
	private Controller_Button conContrller;
	private Scoreupdate conScoreupdate; 

	void Start ()
    {
		GameObject isconScoreupdate = GameObject.FindGameObjectWithTag ("Scoreupdate");

		if (isconScoreupdate != null)
        {
			conScoreupdate = isconScoreupdate.GetComponent<Scoreupdate>();
		}
		if (isconScoreupdate == null)
        {
			Debug.Log("ERROR"); 
		}


		GameObject iscontroller = GameObject.FindGameObjectWithTag ("conNexButton");
	    if(iscontroller != null)
		{
			conContrller = iscontroller.GetComponent<Controller_Button>();
		}
		if (iscontroller == null)
        {
			Debug.Log("Error"); 
		}
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Wall")
        {
			Destroy(gameObject); 
			conContrller.shootNext = true;
		}
		if (other.gameObject.tag == "Point")
        {
			Destroy(gameObject);
			Destroy(other.gameObject);
			conScoreupdate.ScoreAdd();
			conContrller.shootNext = true;
            PointManager.Instance.randomPoint();
           
		}
		if (other.gameObject.tag == "Wall3")
        {
			Destroy(gameObject); 
			conContrller.shootNext = true;
		}
	}
    void Update()
    {

    }
}
