using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void Click_Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
