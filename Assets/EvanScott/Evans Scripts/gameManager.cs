using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject[] heldItems;
    public GameObject[] items;
    public int itemsBurned;
    public bool toothbrushUsed = false;
    public bool bedMade = false;
    public bool lightsOn = true;

    private void Start()
    {
        StartCoroutine(lights());
    }

    IEnumerator lights()
    {
        yield return new WaitForSeconds(45);
        lightsOn = false;
        StartCoroutine(lights());
    }
}
