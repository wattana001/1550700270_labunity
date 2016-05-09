using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Controller_Down : MonoBehaviour
{
	public Quaternion rotation = Quaternion.identity;
	public int Numbuttondown = 0;
	public int Numbuttonup = 0;
	public Button buttonclickup;
	public Button buttonclickdown; 

	public void OnClickUp()
	{
		if (Numbuttonup < 7)
        {
			transform.Rotate (new Vector3 (-1, 0, 0), 5);
            buttonclickup.enabled = true; 
			Numbuttonup++;
			Numbuttondown--;
		} 
		if(Numbuttonup > 7)
        {
            buttonclickdown.enabled = false; 
		}
	}
    public void OnClickDown()
    {
        if (Numbuttondown < 7)
        {
            transform.Rotate(new Vector3(1, 0, 0), 5);
            buttonclickup.enabled = true;
            Numbuttondown++;
            Numbuttonup--;
        }
        if (Numbuttondown > 7)
        {
            buttonclickdown.enabled = false;
        }
    }
    void Update()
    {

    }
}
