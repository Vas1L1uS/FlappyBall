using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] private WallsController _wallsController;
    [SerializeField] private GameObject _blockPrefab;
    [SerializeField] private float _spawnFrequency;

    private float _timeToSpawn;
    private float _maxDeviation = 0.5f;
    private float _currentTime = 0;

    private float _spawn_X_position = 20;
    private float _spawn_Y_position = 0;
    private float _maxHeight = 3.5f;

    private void Start()
    {
        _timeToSpawn = Random.Range(_spawnFrequency - _maxDeviation, _spawnFrequency + _maxDeviation);
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _timeToSpawn)
        {
            SpawnBlock();
            _timeToSpawn = Random.Range(_spawnFrequency - _maxDeviation, _spawnFrequency + _maxDeviation);
            _currentTime = 0;
        }
    }

    private void SpawnBlock()
    {
        _spawn_Y_position = Random.Range(-_maxHeight, _maxHeight);
        GameObject newBlock = Instantiate(_blockPrefab, new Vector3(_spawn_X_position, _spawn_Y_position, 0), Quaternion.Euler(0, 0, 0));
        newBlock.GetComponent<BlockMovement>().Speed = _wallsController.Speed;
    }
}
