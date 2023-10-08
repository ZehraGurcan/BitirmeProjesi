using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public Image i1;
    public Image i2;
    public Image i3;
    public Image i4;


    public void Basla()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void cikis()
    {
        Application.Quit();
    }

    public void Devam1()
    {
        i1.gameObject.SetActive(false);
        i2.gameObject.SetActive(true);
    }public void Devam2()
    {
        i2.gameObject.SetActive(false);
        i3.gameObject.SetActive(true);
    }public void Devam3()
    {
        i3.gameObject.SetActive(false);
        i4.gameObject.SetActive(true);
    }
}
