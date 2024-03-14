using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonLookController : MonoBehaviour
{
    //Variables
    public Transform player;
    public float mouseSens = 2.0f;
    float cameraVerticalRotation = 0.0f;

    bool lockedCursor = true;
    
    // Start is called before the first frame update
    void Start()
    {
        //Lock and hide cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Get mouse positions
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float userInputX = mouseX * mouseSens;
        float userInputY = mouseY * mouseSens;

        //Rotate Camera
        //
        //Vertical
        cameraVerticalRotation -= userInputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90.0f, 90.0f);
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;
        //Horizontal
        player.Rotate(Vector3.up * userInputX);
    }
}
