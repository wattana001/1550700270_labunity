using UnityEngine;
using System.Collections;

public class ClickGameNextScreen : MonoBehaviour {

    public void OnClickStart()
    {
        Application.LoadLevel("Screen02");
    }
    void Update()
    {

    }
}
