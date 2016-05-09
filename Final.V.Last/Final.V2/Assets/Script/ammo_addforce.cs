using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ammo_addforce : MonoBehaviour
{
	public float setspeed; 


	// Use this for initialization
	void Start ()
    {

		GetComponent<Rigidbody> ().AddForce (0f, 5f, setspeed);

	}
	
	// Update is called once per frame
	void Update ()
    {
		 

	}
	public void OnSlider(Slider data)
	{
		setspeed = data.value; 
	}
}
