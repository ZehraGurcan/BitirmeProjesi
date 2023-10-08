using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterBar : MonoBehaviour
{
    public float can, animSpeed;
    private float maxCan, realScale;



    void Start()
    {
        can = 100;
        maxCan = can;
    }


    void Update()
    {

        realScale = can / maxCan;

        if (transform.localScale.x > realScale)
        {
            transform.localScale = new Vector3(transform.localScale.x - (transform.localScale.x - realScale) / animSpeed, transform.localScale.y, transform.localScale.z);
        }

        if (transform.localScale.x < realScale)
        {
            transform.localScale = new Vector3(transform.localScale.x + (realScale - transform.localScale.x) / animSpeed, transform.localScale.y, transform.localScale.z);
        }

        /*if (Input.GetKeyDown(KeyCode.T))
        {
            can += 20;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            can -= 20;
        }*/

        if (can < 0)
            can = 0;

        if (can > 100)
            can = 100;
    }
}
