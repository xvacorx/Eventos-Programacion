using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    private Vector3 moveDirection;
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        moveDirection = new(horizontalInput, 0, verticalInput);
        moveDirection.Normalize();

        transform.Translate(moveSpeed * Time.deltaTime * moveDirection);
    }
}
