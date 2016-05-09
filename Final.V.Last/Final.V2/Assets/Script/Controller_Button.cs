using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
public class Controller_Button : MonoBehaviour
{
	public Button game; 
	public GameObject Ammo; 
	public Transform SpawnPoint; 
	public int AmmoValue = 10;
	public Text AmmoText; 
	public bool shootNext;
	public GameObject Parnel; 
	// Use this for initialization
	void Start ()
    {
		shootNext = true;
		Parnel.SetActive (false); 
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

	public void OnClickShoot()
	{
		if (shootNext == true && AmmoValue >=	 1)
        {
			AmmoValue -= 1;
			AmmoText.text = "Bullet: "+AmmoValue.ToString();
			Instantiate (Ammo, SpawnPoint.transform.position, Quaternion.identity);
			shootNext = false;
		}
		if (AmmoValue <= 0)
        {
			Parnel.SetActive (true); 
		}
	}
	public void OnClickGameStart()
	{
		Application.LoadLevel("Screen02");
	}
	public void OnClickGameMain()
	{
		Application.LoadLevel("Screen01");
	}



}
