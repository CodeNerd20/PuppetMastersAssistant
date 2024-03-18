using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject door;
    public bool interacted;
    public bool doorButton = true;
    public GameObject player;
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
            else if(door.GetComponent<doorIdentifier>().opened == true && interacted == false)
            {
                door.GetComponent<doorIdentifier>().opened = false;
                interacted = true;
            }
            
        }
    }
}
