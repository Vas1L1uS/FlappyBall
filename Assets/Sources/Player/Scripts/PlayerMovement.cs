using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float VerticalSpeed
    {
        get { return _verticalSpeed; }
        set { if (value >= 0) _verticalSpeed = value; }
    }

    private float _verticalSpeed;

    private void Awake()
    {
        _verticalSpeed = StartSettings.PlayerVerticalSpeed;
    }

    public void VerticalMove(bool buttonUpPressed)
    {
        if (buttonUpPressed)
        {
            gameObject.transform.Translate(Vector3.up * _verticalSpeed * Time.deltaTime);
        }
        else
        {
            gameObject.transform.Translate(Vector3.down * _verticalSpeed * Time.deltaTime);
        }
    }  
}
