using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBurner : MonoBehaviour
{
    private GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            Destroy(other.gameObject);
            gameManager.GetComponent<gameManager>().itemsBurned += 1;
        }
    }
}
