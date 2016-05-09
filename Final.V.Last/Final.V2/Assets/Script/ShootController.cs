using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ShootController : MonoBehaviour
{
	private Slider mSlider; 
	private ammo_addforce conammo; 
	public GameObject ammo; 
	void Awake()
	{
		mSlider = this.GetComponent<Slider> ();
	}

	// Use this for initialization
	void Start ()
    {
		GameObject isconammo = GameObject.FindGameObjectWithTag ("Ammo");
		if (isconammo != null)
        {
			conammo = isconammo.GetComponent<ammo_addforce>();
		}
		if (isconammo == null)
        {
			Debug.Log("Error");
		}

	}
	
	// Update is called once per frame
	void FixUpdate ()
    {
		
		
	}

	public void OnSlider()
	{
        if(conammo != null)
        {
            conammo.setspeed = mSlider.value;
        }
		  
	}

}
