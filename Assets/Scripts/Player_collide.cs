using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_collide : MonoBehaviour
{ 
    void OnCollisionEnter2D(Collision2D collision)
    {
        //if the character collides with an obstacle
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } else if (collision.gameObject.tag == "win_block")
        {
            Debug.Log("You win");
            SceneManager.LoadScene(1);
        }
    }
}
