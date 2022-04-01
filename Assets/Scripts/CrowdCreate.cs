using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdCreate : MonoBehaviour
{
    [SerializeField]
    private int _spawnCount;
    [SerializeField]
    private GameObject _spawnPrefab;

    public void CrowdSpawner()
    {
        for (int i = 0; i < _spawnCount; i++)
        {
            Instantiate(_spawnPrefab,transform);
        }
    }
}
