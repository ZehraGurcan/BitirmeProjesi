using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour
{
    HealthBar health;
    public GameObject water;
    public GameObject sun;
    public GameObject earth;
    //ItemTutan itemTutan;
    //Item item;

    public GameObject flower;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Water"))
        {
            water.GetComponent<WaterBar>().can += 20;
            
        }
        else if (other.gameObject.CompareTag("FullWater"))
        {
            water.GetComponent<WaterBar>().can += 100;
        }
        else if (other.gameObject.CompareTag("Earth"))
        {
            earth.GetComponent<EarthBar>().can += 20;
        }
        else if (other.gameObject.CompareTag("Sun"))
        {
            sun.GetComponent<SunBar>().can += 20;
        }
    }

}
