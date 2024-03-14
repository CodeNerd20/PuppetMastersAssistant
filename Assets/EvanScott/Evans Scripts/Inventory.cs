using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject[] items;
    public GameObject[] heldItems;
    public int[] slots;
    public int handSelected;
    public int itemInHands;
    public GameObject gameManager;
    public GameObject itemDropPoint;
    public int slotsUpdater = 1;
    void Start()
    {
        handSelected = 0;
        gameManager = GameObject.Find("GameManager");
        heldItems = gameManager.GetComponent<gameManager>().heldItems;
        items = gameManager.GetComponent<gameManager>().items;
    }


    void Update()
    {
        if (itemInHands - 1 > -1)
        {
            heldItems[itemInHands - 1].SetActive(true);
        }

        if (slots[slotsUpdater] > 0)
        {
            //slotsUI[slotsUpdater].GetComponent<ItemDisplay>().image.sprite = slotsUI[slotsUpdater].GetComponent<ItemDisplay>().weighted;
        }
        else
        {
            //slotsUI[slotsUpdater].GetComponent<ItemDisplay>().image.sprite = slotsUI[slotsUpdater].GetComponent<ItemDisplay>().nonWeighted;
        }
        slotsUpdater += 1;
        if (slotsUpdater > 3)
        {
            slotsUpdater = 0;
        }
        if (itemInHands == 3)


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            handSelected = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            handSelected = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            handSelected = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            handSelected = 3;
        }
        itemInHands = slots[handSelected];
        if (Input.GetKeyDown(KeyCode.G) && slots[handSelected] > 0)
        {
            Instantiate(items[itemInHands - 1], itemDropPoint.transform.position, itemDropPoint.transform.rotation);
            slots[handSelected] = 0;
        }
    }

}
