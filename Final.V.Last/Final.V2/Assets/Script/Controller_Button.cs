using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
public class Controller_Button : MonoBehaviour
{
	public Button game; 
	public GameObject Ammo; 
	public Transform SpawnPoint; 
	public int NumberAmmo = 15;
	public Text AmmoText; 
	public bool ShootNext;
	public GameObject Parnel; 
	void Start ()
    {
		ShootNext = true;
		Parnel.SetActive (false); 
	}

	public void OnClickShoot()
	{
		if (ShootNext == true && NumberAmmo >=	 1)
        {
            NumberAmmo -= 1;
			AmmoText.text = "Bullet: "+ NumberAmmo.ToString();
			Instantiate (Ammo, SpawnPoint.transform.position, Quaternion.identity);
			ShootNext = false;
		}
		if (NumberAmmo <= 0)
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
