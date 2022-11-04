using System.Collections.Generic;
using UnityEngine;

public class WallsController : MonoBehaviour
{
    [SerializeField] public float Speed;

    [Header ("������ ����������� ����")]
    [SerializeField] private List<WallsMovement> _listWalls; // WallsMovement ����� �� �������� ������ ������
    [SerializeField] private float _position_X_ToTeleportation;

    private List<Transform> _listWallsTransform;
    private Transform _lastLineWallsTransform;
    private Transform _firstLineWallsTransform;
    private float _backSizeLastElement = 51.5f;

    private void Start()
    {
        _listWallsTransform = new List<Transform>();

        DublicateListWallsMovementToTransform(_listWalls);
        SetSpeedToAllWalls(_listWalls);

        RefreshListSettings();

        //_backSizeLastElement = _lastLineWallsTransform.GetComponentInChildren<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        if (_firstLineWallsTransform.position.x <= _position_X_ToTeleportation)
        {
            TeleportToEndLastElement(_firstLineWallsTransform);
            PermutationElementsDown(_listWallsTransform);
            RefreshListSettings();
        }
    }

    /// <summary>
    /// ��������� ������ ���� � ������������� ��� ������ Transform
    /// </summary>
    private void DublicateListWallsMovementToTransform(List<WallsMovement> listWalls)
    {
        foreach (var item in listWalls)
        {
            _listWallsTransform.Add(item.GetComponent<Transform>());
        }
    }

    /// <summary>
    /// ������ �������� ���� ��������� � ������ ����
    /// </summary>
    private void SetSpeedToAllWalls(List<WallsMovement> listWalls)
    {
        foreach (var item in listWalls)
        {
            item.Speed = Speed;
        }
    }

    /// <summary>
    /// ������������ � ����� ���������� ��������
    /// </summary>
    /// <param name="_firtsElement"></param>
    private void TeleportToEndLastElement(Transform _firtsElement)
    {
        _firtsElement.position = new Vector3(_lastLineWallsTransform.position.x + _backSizeLastElement, 0, 0);
    }

    /// <summary>
    /// ���������� ������ �� ������� ��������� ����� ������� x0 < x1
    /// </summary>
    /// <param name="listWalls"></param>
    private void SortedListByPosition(List<Transform> listWalls)
    {
        Transform temp;

        for (int i = 1; i < listWalls.Count; i++)
        {
            if (listWalls[i - 1].position.x > listWalls[i].position.x)
            {
                temp = listWalls[i - 1];
                listWalls[i - 1] = listWalls[i];
                listWalls[i] = temp;

                i = 0;
            }
        }
    }

    /// <summary>
    /// �������� ��������� ������ �� 1 ����
    /// </summary>
    /// <param name="listWalls"></param>
    private void PermutationElementsDown(List<Transform> listWalls)
    {
        Transform temp;

        temp = listWalls[0];

        for (int i = 0; i < listWalls.Count - 1; i++)
        {
            listWalls[i] = listWalls[i + 1];
        }

        listWalls[listWalls.Count - 1] = temp;
    }

    /// <summary>
    /// ���������, ������� ������ � ��������� ������� � ������
    /// </summary>
    private void RefreshListSettings()
    {
        SortedListByPosition(_listWallsTransform);
        _firstLineWallsTransform = _listWallsTransform[0];
        _lastLineWallsTransform = _listWallsTransform[_listWallsTransform.Count - 1];
    }
}
