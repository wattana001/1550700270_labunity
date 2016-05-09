using UnityEngine;
using System.Collections;

public class Wall_Tranform : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		GetComponent<Rigidbody> ().velocity = new Vector3 (0f,10f,0f);
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
	void OnCollisionEnter(Collision other)

	{
		if (other.gameObject.tag == "Wall1")
        {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0f,-10f,0f);
		}
		if (other.gameObject.tag == "Wall2")
        {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0f,10f,0f);
		}
	}
}
