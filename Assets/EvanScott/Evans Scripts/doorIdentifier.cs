using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorIdentifier : MonoBehaviour
{
    public bool opened;
    public MeshRenderer rend;
    public BoxCollider collide;
    public Rigidbody rigid;
    private GameObject gameManager;
    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
        rend = GetComponent<MeshRenderer>();
        collide = GetComponent<BoxCollider>();
        rigid = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(opened == true)
        {
            rend.enabled = false;
            collide.enabled = false;
        }
        if (opened == false)
        {
            rend.enabled = true;
            collide.enabled = true;        
        }
    }
}
