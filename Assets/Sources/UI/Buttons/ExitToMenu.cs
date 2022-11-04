using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMenu : MonoBehaviour
{
    public void Click_ExitToMenu()
    {
        SceneManager.LoadScene(GlobalVars.MAIN_MENU_SCENE);
    }
}
