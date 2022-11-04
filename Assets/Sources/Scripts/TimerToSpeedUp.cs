using UnityEngine;

public class TimerToSpeedUp : MonoBehaviour
{
    [SerializeField] private float _timeToUpSpeed;
    private float _coeffUp;

    private PlayerMovement _player;
    private float currentTime = 0;

    void Start()
    {
        _coeffUp = StartSettings.CoeffUp;
        _player = FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {
        SpeedUpByTimer();
    }

    /// <summary>
    /// Таймер и ускорение
    /// </summary>
    private void SpeedUpByTimer()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= _timeToUpSpeed)
        {
            _player.VerticalSpeed *= _coeffUp;
            currentTime = 0;
        }
    }
}
