using UnityEngine;

public class Player_move : MonoBehaviour
{
    private Rigidbody2D rb;
    public float sideways_force = 8f;
    public float jump_force = 16f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // gets values of the player rigidbody so it can be moved
    }

    public void jump()
    {
        //if the block is not moving up or down - stops double jumping
        if (Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.velocity = Vector2.up * jump_force; //jumps
        }
    }

    void Update()
    {
        //value it is moving left or right good for arrow keys
        var movement = Input.GetAxis("Horizontal");

        //moves based on the ideways_force and th movement left or right
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * sideways_force;

        Debug.Log(movement);

        //if space pressed for jump and if the block is not moving up or down
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f) 
        {
            jump();
        }
    }

    //upon hitting any block and staying on it
    private void OnCollisionEnter2D(Collision2D colliderInfo)
    {
        //if the block hit is a moving platform
        if (colliderInfo.gameObject.tag == "moving_platform")
        {
            //follow the block
            this.transform.parent = colliderInfo.transform;
        }
    }

    //upon not hitting the block anymore
    private void OnCollisionExit2D(Collision2D colliderInfo)
    {
        //if the block left is a moving platform
        if (colliderInfo.gameObject.tag == "moving_platform")
        {
            //do not follow anymore
            this.transform.parent = null;
        }
    }
}
