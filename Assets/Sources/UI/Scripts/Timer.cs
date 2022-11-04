using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class Timer : MonoBehaviour
{
    private Text _text;

    private int _seconds = 0;
    private int _minutes = 0;
    private float _currentSeconds;

    private void Awake()
    {
        _text = gameObject.GetComponent<Text>();
    }

    private void Update()
    {
        _currentSeconds += Time.deltaTime;
        _seconds = Mathf.FloorToInt(_currentSeconds);

        Print();

        if (_seconds >= 60)
        {
            _seconds = 0;
            _currentSeconds = 0;
            _minutes++;
        }
    }

    private void Print()
    {
        string strMinutes = string.Format("{0:d2}", _minutes);
        string strSeconds = string.Format("{0:d2}", _seconds);
        _text.text = $"{strMinutes}:{strSeconds}";
    }
}
