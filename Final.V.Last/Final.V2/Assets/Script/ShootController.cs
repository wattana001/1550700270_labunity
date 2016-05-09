using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ShootController : MonoBehaviour
{
    private Slider mSlider;
    private Speed conammo;
    public GameObject ammo;
    void Awake()
    {
        mSlider = this.GetComponent<Slider>();
    }

    void Start()
    {
        GameObject isconammo = GameObject.FindGameObjectWithTag("Bullet");
        if (isconammo != null)
        {
            conammo = isconammo.GetComponent<Speed>();
        }
        if (isconammo == null)
        {
            Debug.Log("Error");
        }

    }

    public void OnSlider()
    {
        if (conammo != null)
        {
            conammo.speed = mSlider.value;
        }
    }
}
