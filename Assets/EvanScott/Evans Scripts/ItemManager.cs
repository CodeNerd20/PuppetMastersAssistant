using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public float maxRange;
    public bool grabable;
    public GameObject itemToGrab;
    private GameObject gameManager;
    public Inventory inventory;
    public bool Interactable;
    public GameObject itemToInteract;
    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && grabable && inventory.slots[inventory.handSelected] == 0)
        {
            inventory.slots[inventory.handSelected] = itemToGrab.GetComponent<itemIdentifier>().itemNum;
            Destroy(itemToGrab);
            //gameManager.GetComponent<roomLimiter>().itemAmount += 1;
            grabable = false;
            itemToGrab = null;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && Interactable)
        {
            
            
                
                    Debug.Log("attempted interact");
                    itemToInteract.GetComponent<button>().Invoke("Interacted", 0);
               
            
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
           
            grabable = true;
            itemToGrab = other.gameObject;
            other.gameObject.GetComponent<Outline>().enabled = true;
        }
        if (other.gameObject.CompareTag("Interactable"))
        {
            other.gameObject.GetComponent<Outline>().enabled = true;
            
                
                    Interactable = true;
                    itemToInteract = other.gameObject;
                
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            other.gameObject.GetComponent<Outline>().enabled = false;
            grabable = false;
        }
        if (other.gameObject.CompareTag("Interactable"))
        {
            other.gameObject.GetComponent<Outline>().enabled = false;
            Interactable = false;
        }
    }
}
