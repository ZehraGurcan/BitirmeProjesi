using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    //public FlowerInventory flowerInventory;

    public GameObject flower;
    public GameObject dad;
    public GameObject mom;

    public GameObject water;
    public GameObject earth;
    public GameObject sun;
    public GameObject health;

    public GameObject gameEnd;
    public GameObject dayEnd;

    public GameObject hava;

    public bool dayDevam;
    public bool alreadyHappened;

    public TextMeshProUGUI textStats;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(health.GetComponent<HealthBar>().can == 0)
        {
            gameEnds();
        }

        if (hava.GetComponent<Timer>().saat >= 21)
        {
            dayDevam = false;
            dayEnds();
        }

        if (health.GetComponent<HealthBar>().can == 0)
        {
            gameEnds();
        }
    }

    public void dayEnds()
    {

        if(dayDevam == false)
        {
            dayEnd.gameObject.SetActive(true);
            Cursor.visible = true;
            flower.GetComponent<CharacterMovements>().enabled = false;
            dad.GetComponent<Animator>().enabled = false;
            mom.GetComponent<Animator>().enabled = false;

            if(alreadyHappened == false)
            {
                water.GetComponent<WaterBar>().can -= 20;
                sun.GetComponent<SunBar>().can -= 40;
                earth.GetComponent<EarthBar>().can -= 30;
                 
                alreadyHappened = true;
            }
            

            

            PlayerPrefs.SetFloat("Health", health.GetComponent<HealthBar>().can);
            PlayerPrefs.SetFloat("Water", water.GetComponent<WaterBar>().can);
            PlayerPrefs.SetFloat("Sun", sun.GetComponent<SunBar>().can);
            PlayerPrefs.SetFloat("Earth", earth.GetComponent<EarthBar>().can);

            textStats.text = "Can: " + PlayerPrefs.GetFloat("Health", 100) + "       Su: " + PlayerPrefs.GetFloat("Water", 100)
                + "\nGün Iþýðý: " + PlayerPrefs.GetFloat("Sun", 100) + "            Toprak Kirliliði: " + PlayerPrefs.GetFloat("Earth", 100);


            if (health.GetComponent<HealthBar>().can == 0)
            {
                gameEnds();
            }

            
        }
        
    }

    public void dayStarts()
    {
        dayEnd.gameObject.SetActive(false);
        Cursor.visible = false;
        flower.GetComponent<CharacterMovements>().enabled = true;
        dad.GetComponent<Animator>().enabled = true;
        mom.GetComponent<Animator>().enabled = true;

        hava.GetComponent<Timer>().day++;
        alreadyHappened = false;
        hava.GetComponent<Timer>().zaman = 0;
        hava.GetComponent<Timer>().saat = 0;
        hava.GetComponent<Timer>().dk = 0;
        hava.GetComponent<Timer>().zaman = (hava.GetComponent<Timer>().saat * 15.0f) + (hava.GetComponent<Timer>().dk * 0.25f);
        hava.GetComponent<Timer>().zaman2 = 480;
        hava.GetComponent<Timer>().dayIsActive = true;

        dayDevam = true;
    }

    public void gameEnds()
    {
        gameEnd.gameObject.SetActive(true);
        Cursor.visible = true;
        flower.GetComponent<CharacterMovements>().enabled = false;
        dad.GetComponent<Animator>().enabled = false;
        mom.GetComponent<Animator>().enabled = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") )
        {
            gameEnds();
        }
    }

}