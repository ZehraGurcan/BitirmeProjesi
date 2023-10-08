using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public float can, animSpeed;
    private float maxCan, realScale;

    public GameObject su;
    public GameObject gunes;
    public GameObject toprak;

    bool suFirstTime = true;
    bool gunesFirstTime = true;
    bool toprakFirstTime = true;

    void Start()
    {
        maxCan = can;
    }

    
    void Update()
    {

        realScale = can / maxCan;

        if(transform.localScale.x > realScale)
        {
            transform.localScale = new Vector3(transform.localScale.x - (transform.localScale.x - realScale)/animSpeed,transform.localScale.y, transform.localScale.z);
        }

        if (transform.localScale.x < realScale)
        {
            transform.localScale = new Vector3(transform.localScale.x + (realScale - transform.localScale.x) / animSpeed, transform.localScale.y, transform.localScale.z);
        }


        susuzluk();
        gunIsýgýYoksunlugu();
        toprakKirliligi();
        

        if (can < 0)
            can = 0;

        if(can > 100)
            can = 100;
    }

    //su barý bittiðinde can düþürür
    public void susuzluk()
    {
        if (su.GetComponent<WaterBar>().can == 0)
        {
            if (suFirstTime)
            {
                can -= 10;
                suFirstTime = false;
            }

        }
        else
        {
            suFirstTime = true;
        }
    }

    //gunes barý bittiðinde can düþürür
    public void gunIsýgýYoksunlugu()
    {
        if (gunes.GetComponent<SunBar>().can == 0)
        {
            if (gunesFirstTime)
            {
                can -= 10;
                gunesFirstTime = false;
            }

        }
        else
        {
            gunesFirstTime = true;
        }
    }

    //toprak barý bittiðinde can düþürür
    public void toprakKirliligi()
    {
        if (toprak.GetComponent<EarthBar>().can == 0)
        {
            if (toprakFirstTime)
            {
                can -= 10;
                toprakFirstTime = false;
            }

        }
        else
        {
            toprakFirstTime = true;
        }
    }
}
