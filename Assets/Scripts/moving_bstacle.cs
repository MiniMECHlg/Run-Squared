using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_bstacle : MonoBehaviour
{

    private Rigidbody2D rb;
    public bool axis = false; //true = y - false = x
    public bool direction = true; //true = right - false = left
    public float movement_speed = 5f;
    public float movement_upper; //how much it should move by
    public float movement_lower; //how much it should move by

    // Start is called before the first frame update
    void Start()
    {
        //initilaises the rigidbody to use
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if you want to move left or right
        if (axis == false)
        {
            //move right
            if (direction == true)
            {
                //moves right
                transform.position += new Vector3(movement_speed, 0, 0) * Time.deltaTime;
                // if it is or more than the upper bound in position x
                if ((movement_upper) <= rb.transform.position.x)
                {
                    //move left
                    direction = false;
                } 
            }
            else
            {
                //moves left
                transform.position += new Vector3(-movement_speed, 0, 0) * Time.deltaTime;
                // if it is or less than the lower bound in position x
                if ((movement_lower) >= rb.transform.position.x)
                {
                    //move right
                    direction = true;
                }
            }
        // move in the y axis
        } else
        {
            //move up
            if (direction == true)
            {
                // moves up
                transform.position += new Vector3(0, movement_speed, 0) * Time.deltaTime;
                //if not higher up or the same height as upper bound
                if ((movement_upper) <= rb.transform.position.y)
                {
                    //move down
                    direction = false;
                }
            //move down
            } else
            {
                //moves down
                transform.position += new Vector3(0, -movement_speed, 0) * Time.deltaTime;
                //if not lower or the same height as lower bound
                if ((movement_lower) >= rb.transform.position.y)
                {
                    //move up
                    direction = true;
                }
            }

        }
    }
}
