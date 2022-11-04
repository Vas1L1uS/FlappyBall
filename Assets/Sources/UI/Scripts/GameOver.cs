using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject _gameObjects;
    [SerializeField] private GameObject _gameoverCanvas;
    [SerializeField] private GameObject _hud;
    [SerializeField] private Text _timer;

    private GameOverCanvas _gameoverCanvasScript;

    private void Start()
    {
        _gameoverCanvasScript = _gameoverCanvas.GetComponent<GameOverCanvas>();
    }
    public void PlayerGameOver()
    {
        _gameoverCanvas.SetActive(true);
        _gameoverCanvasScript.Activation(_timer.text);
        _gameObjects.SetActive(false);
        _hud.SetActive(false);
    }
}
