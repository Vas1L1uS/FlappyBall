using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameLevel : MonoBehaviour
{
    public void Click_Start()
    {
        SceneManager.LoadScene(GlobalVars.LEVEL_SCENE);
    }
}
