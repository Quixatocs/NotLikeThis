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
        
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        if (isJumping == false && Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);
            StartCoroutine(jumpTimer());
        }

        if (moveDirection.x > 0f)
        {
            transform.localScale = new Vector3(-0.5f, transform.localScale.y, 1f);
        }
        else if (moveDirection.x < 0f)
        {
            transform.localScale = new Vector3(0.5f, transform.localScale.y, 1f);
        }

        transform.position += moveDirection * Time.deltaTime;
    }

    private IEnumerator jumpTimer() {
        yield return jumpWait;
        isJumping = false;
    }



}
