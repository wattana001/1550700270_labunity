using UnityEngine;
using System.Collections;

public class Wall_block : MonoBehaviour
{

    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0f, 10f, 0f);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall1")
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0f, -10f, 0f);
        }
        if (other.gameObject.tag == "Wall2")
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0f, 10f, 0f);
        }
    }
    void Update()
    {

    }
}
