using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float hiz;
    public float zaman;
    public float zaman2;
    public float dk;
    public float saat;

    public bool timerActive = true;

    public TextMeshProUGUI yazi;

    public bool dayIsActive = true;
    public int day = 1;

    void Start()
    {
        zaman = (saat * 15.0f) + (dk * 0.25f) ;
        dayIsActive = true;
        
    }

    
    void Update()
    {
            if (dayIsActive == true)
            {
                //saat ve dk mantýðý
                zaman += hiz * Time.deltaTime;
                zaman2 = (zaman / 0.25f) + 480;
                dk = zaman2 % 60;
                saat = (zaman2 - dk) / 60;

                if (zaman > 360.0f)
                {
                    zaman = 0;
                }

                transform.eulerAngles = new Vector3(zaman - 90, 0, 0);
                yazi.text = "Saat:  " + saat.ToString("0") + " : " + dk.ToString("0") + " \n" + "Gün: " + day.ToString();
            }
            
        
        

        //gün aktif mi

        if(saat<=20 && saat>=8)
        {
            dayIsActive = true;
        }
        else
        {
            dayIsActive = false;
        }
    }
}
