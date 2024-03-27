using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject door;
    public bool interacted;
    public bool doorButton = true;
    public GameObject player;
    public bool toothbrush = false;
    public bool bed = false;
    public bool breakerBox = false;
    public GameObject gameManager;
    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }
    public void Interacted()
    {
        if (doorButton)
        {
            interacted = false;
            if (door.GetComponent<doorIdentifier>().opened == false && interacted == false)
            {
                door.GetComponent<doorIdentifier>().opened = true;
                interacted = true;
            }
            else if (door.GetComponent<doorIdentifier>().opened == true && interacted == false)
            {
                door.GetComponent<doorIdentifier>().opened = false;
                interacted = true;
            }

        }

        if (toothbrush)
        {
            gameManager.GetComponent<gameManager>().toothbrushUsed = true;
            interacted = true;
        }
        else if (bed)
        {
            gameManager.GetComponent<gameManager>().bedMade = true;
            interacted = true;
        }
        else if (breakerBox)
        {
            gameManager.GetComponent<gameManager>().lightsOn = true;
            interacted = true;
        }

    }
}
