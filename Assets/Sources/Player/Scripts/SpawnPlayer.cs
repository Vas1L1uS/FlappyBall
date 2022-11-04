using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;

    private void Awake()
    {
        SpawnMyPlayer();
    }

    public void SpawnMyPlayer()
    {
        Instantiate(_playerPrefab, gameObject.transform.position, Quaternion.Euler(0, 0, 0));
    }
}
