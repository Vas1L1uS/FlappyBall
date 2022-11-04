using UnityEngine;

public class GameoverCollider : MonoBehaviour
{
    private Collider2D _playerCollider;
    private GameOver _gameOver;

    private void Start()
    {
        _playerCollider = FindObjectOfType<PlayerMovement>().GetComponent<Collider2D>();
        _gameOver = FindObjectOfType<GameOver>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == _playerCollider)
        {
            _gameOver.PlayerGameOver();
        }
    }
}
