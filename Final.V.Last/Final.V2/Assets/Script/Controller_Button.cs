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
	void Start ()
    {
		shootNext = true;
		Parnel.SetActive (false); 
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
    void Update()
    {

    }
}
