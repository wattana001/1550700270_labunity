using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public float speed;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(0f, 5f, speed);
    }
    public void OnSlider(Slider data)
    {
        speed = data.value;
    }
    void Update()
    {

    }
}
