using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMovements : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject flower;
    public float moveSpeed;
    public float rotateSpeed;
    public float minRot;
    public float maxRot;
    float xCurRot;
    public float zipla;
    public bool ziplamaActive;
    float mv;
    void Start()
    {
        xCurRot = 50;
        ziplamaActive = false;
        mv = moveSpeed;
    }


    void Update()
    {
        //Rotation
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        xCurRot += -y * rotateSpeed;
        xCurRot = Mathf.Clamp(xCurRot, minRot, maxRot);

        transform.eulerAngles = new Vector3(xCurRot, transform.eulerAngles.y + (x * rotateSpeed), 0.0f);

        //Movement
        Vector3 forward = flower.transform.forward;
        forward.y = 0.0f;
        forward.Normalize();

        Vector3 right = flower.transform.right;

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        Vector3 dir = forward * moveZ + right * moveX;

        dir.Normalize();

        dir *= moveSpeed * Time.deltaTime;

        transform.position += dir;

        //Move Faster

        if (Input.GetKey(KeyCode.LeftShift))
        {
            
            moveSpeed=6;
        }
        else
        {
            moveSpeed=mv;
        }

        //jump

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ziplamaActive == false)
            {
                ziplamaActive = true;
                rb.AddForce(new Vector3(0.0f, zipla * 10, 0.0f));

            }
        }

        
    }


    
    void OnCollisionEnter(Collision other)
    {
        

        if(other.gameObject.CompareTag("Yer"))
        {
            ziplamaActive = false;
        }
    }

}
        
    