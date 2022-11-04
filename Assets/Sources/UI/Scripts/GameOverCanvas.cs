using UnityEngine;
using UnityEngine.UI;

public class GameOverCanvas : MonoBehaviour
{
    [SerializeField] private Text _bestTime;
    [SerializeField] private Text _currentTime;

    /// <summary>
    /// Запуск скрипта GameOverCanvas с последуещей реализацией
    /// </summary>
    /// <param name="time"></param>
    public void Activation(string time)
    {
        _currentTime.text = time;
        CheckTimeWithBestResult(time);
        _bestTime.text = SaveController.GetBestResultByLevel();
    }

    private void CheckTimeWithBestResult(string time)
    {
        SaveController.SaveBestResultByLevel(time);
    }
}
