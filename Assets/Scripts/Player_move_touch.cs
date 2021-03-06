using UnityEngine;

public class Player_move_touch : MonoBehaviour
{
    private Rigidbody2D rb;
    public float sideways_force = 8f;
    private float ScreenWidth;
    public bool left = false;
    public bool right = false;

    void Start()
    {
        //gets values of the player rigidbody so it can be moved
        rb = GetComponent<Rigidbody2D>();
        //gets screenwidth
        ScreenWidth = Screen.width;
    }

    public void Update()
    {
        /*
        int i = 0;
        while (i < Input.touchCount)
        {
            //if the person is pressing the right hand side of the screen
            if (Input.GetTouch(i).position.x > ScreenWidth / 2)
            {
                //move right
                transform.position += new Vector3(sideways_force, 0, 0) * Time.deltaTime;
            }
            //if the person is pressing the left hand side of the screen
            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                //move left
                transform.position += new Vector3(-sideways_force, 0, 0) * Time.deltaTime;
            }
            ++i;
        }
        */

        if(left == true)
        {
           transform.position -= new Vector3(1, 0, 0) * Time.deltaTime * sideways_force;
        }
        else if (right == true)
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * sideways_force;
        }
    }

    public void left_down()
    {
        left = true;
    }

    public void right_down()
    {
        right = true;
    }

    public void left_up()
    {
        left = false;
    }

    public void right_up()
    {
        right = false;
    }
}
