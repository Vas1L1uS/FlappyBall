using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _playerMovement;

    private void Start()
    {
        _playerMovement = FindObjectOfType<PlayerMovement>();
    }

    private bool _buttonUpPressed;

    private void Update()
    {
        if (Input.GetKey(GlobalVars.MoveUP) || Input.GetKey(GlobalVars.MoveUpAlternative))
        {
            _buttonUpPressed = true;
        }
        else
        {
            _buttonUpPressed = false;
        }

        _playerMovement.VerticalMove(_buttonUpPressed);
    }
}
