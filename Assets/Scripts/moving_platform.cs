using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_platform : MonoBehaviour
{
    public bool direction = true; //true = right false = left
    private Rigidbody2D rb;
    public float movement_speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // gets values of the player rigidbody so it can be moved
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (direction == true)
        {
            //moves right
            transform.position += new Vector3(movement_speed, 0, 0) * Time.deltaTime; 
        }
        else
        {
            //moves left
            transform.position += new Vector3(-movement_speed, 0, 0) * Time.deltaTime; 
        }
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        //if it hits a platoform
        if (collisionInfo.collider.tag == "platform")
        {
            if (direction == true)
            {
                //move left from right
                direction = false;
            }
            else
            {
                //move right from left
                direction = true;
            }
        }
    }
}



