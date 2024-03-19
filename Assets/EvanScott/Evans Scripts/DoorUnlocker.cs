using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUnlocker : MonoBehaviour
{
    public int doorOpen;
    private GameObject gameManager;
    public Rigidbody rb;
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (gameManager.GetComponent<gameManager>().itemsBurned >= doorOpen)
        {
            rb.isKinematic = false;
        }
        else 
        {
            rb.isKinematic = true;
        }
    }
}
