using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lights : MonoBehaviour
{
    private GameObject gameManager;
    public Light mylight;
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        //mylight = gameManager.GetComponent<Light>();
    }

    void Update()
    {
        if (gameManager.GetComponent<gameManager>().lightsOn == false) 
        {
            mylight.enabled = false;
        }
        if (gameManager.GetComponent<gameManager>().lightsOn == true)
        {
            mylight.enabled = true;
        }
    }
}
