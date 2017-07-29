using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 6.0F;
    public float jumpForce = 100.0F;
    private Vector3 moveDirection = Vector3.zero;
	


  
    void Update()
    {

        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        if (Input.GetButtonDown("Jump"))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);

        transform.position += moveDirection * Time.deltaTime;
        //moveDirection.y -= gravity * Time.deltaTime;
       // controller.Move(moveDirection * Time.deltaTime);
    }



}
