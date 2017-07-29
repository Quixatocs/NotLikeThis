using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 6.0F;
    public float jumpForce = 100.0F;
    private Vector3 moveDirection = Vector3.zero;
    private bool isJumping = false;
    private WaitForSeconds jumpWait = new WaitForSeconds(0.75f);





    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        if (isJumping == false && Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);
            StartCoroutine(jumpTimer());
        }

        transform.position += moveDirection * Time.deltaTime;
    }

    private IEnumerator jumpTimer() {
        yield return jumpWait;
        isJumping = false;
    }



}
