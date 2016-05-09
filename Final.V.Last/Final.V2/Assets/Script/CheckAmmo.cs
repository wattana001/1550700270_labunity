using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CheckAmmo : MonoBehaviour
{
	private Controller_Button Controller;
	private Scoreupdate controScoreupdate; 

	void Start ()
    {
		GameObject isconScoreupdate = GameObject.FindGameObjectWithTag ("Scoreupdate");

		if (isconScoreupdate != null)
        {
            controScoreupdate = isconScoreupdate.GetComponent<Scoreupdate>();
		}
		if (isconScoreupdate == null)
        {
			Debug.Log("ERROR"); 
		}


		GameObject iscontroller = GameObject.FindGameObjectWithTag ("conNexButton");
	    if(iscontroller != null)
		{
            Controller = iscontroller.GetComponent<Controller_Button>();
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
            Controller.ShootNext = true;
		}
		if (other.gameObject.tag == "Point")
        {
			Destroy(gameObject);
			Destroy(other.gameObject);
            controScoreupdate.ScoreAdd();
            Controller.ShootNext = true;
            PointManager.Instance.randomPoint();
           
		}
		if (other.gameObject.tag == "Wall3")
        {
			Destroy(gameObject);
            Controller.ShootNext = true;
		}
	}
    void Update()
    {

    }
}
