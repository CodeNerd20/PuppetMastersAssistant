using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        //Vector3 localDirection = transform.InverseTransformDirection(horizontalInput, rb.velocity.y, verticalInput);
        Vector3 move = new Vector3(horizontalInput, 0, verticalInput).normalized * moveSpeed;
        rb.AddRelativeForce(move,ForceMode.Impulse);

        rb.maxLinearVelocity = moveSpeed;

        //transform.Translate(Vector3.forward * moveSpeed * verticalInput * Time.deltaTime);
        //transform.Translate(Vector3.right * moveSpeed * horizontalInput * Time.deltaTime);
    }
}
