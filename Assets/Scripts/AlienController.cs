using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour {

    private const string LASER_SHOT_TAG = "LaserShot";

    private GameObject target;

    public float speed = 0.1F;
    public int shotsToKill = 1;

    private int shotsTaken = 0;


    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        
        target = GameObject.FindGameObjectWithTag("AlienTarget");
    }

    void Update() {
        
        moveDirection = target.transform.position - transform.position;
        moveDirection = transform.TransformDirection(moveDirection);
        //moveDirection *= speed;

        if (moveDirection.x > 0f)
        {
            transform.localScale = new Vector3(-1f, transform.localScale.y, 1f);
        }
        else if (moveDirection.x < 0f)
        {
            transform.localScale = new Vector3(1f, transform.localScale.y, 1f);
        }

        transform.position += moveDirection.normalized * speed * Time.deltaTime;

    }

    

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == LASER_SHOT_TAG)
            shotsTaken += 1;

        if (shotsTaken >= shotsToKill)
            Die();

    }


    private void Die() {
        EventManager.invokeSubscribersTo_AlienDeath(transform.position);
        Destroy(gameObject);
    }
}
