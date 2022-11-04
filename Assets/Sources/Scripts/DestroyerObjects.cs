using System.Collections;
using UnityEngine;

public class DestroyerObjects : MonoBehaviour
{
    private GameObject[] _arrayGameObjects;

    void Start()
    {
        StartCoroutine(TimerToDestroyDistantObjects());
    }

    private IEnumerator TimerToDestroyDistantObjects()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            _arrayGameObjects = FindObjectsOfType<GameObject>();
            foreach (var item in _arrayGameObjects)
            {
                if (item.transform.position.x < gameObject.transform.position.x)
                {
                    Destroy(item);
                }
            }
        }
    }
}
