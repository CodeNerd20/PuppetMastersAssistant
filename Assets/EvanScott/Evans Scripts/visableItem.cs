using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visableItem : MonoBehaviour
{
    private void FixedUpdate()
    {
        gameObject.SetActive(false);
    }
}
