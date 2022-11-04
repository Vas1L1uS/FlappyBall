using UnityEngine;

abstract public class MoveToLeft : MonoBehaviour
{
    public float Speed;

    private void Update()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
    }
}
