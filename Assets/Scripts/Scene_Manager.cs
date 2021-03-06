using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public void main_menu()
    {
        SceneManager.LoadScene(0);
    }

    public void level_select()
    {
        SceneManager.LoadScene(1);
    }

    public void level_1()
    {
        SceneManager.LoadScene(2);
    }

    public void level_2()
    {
        SceneManager.LoadScene(3);
    }
}
