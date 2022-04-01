using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject _playerPrefab;
    [SerializeField]
    private int _addAmount,_factor=1;
    [SerializeField]
    private TextMeshProUGUI _tmpro;
    public void Spawn()
    {
        if (_factor>1)
        {
            _addAmount = (GameManager.Instance.player.transform.childCount - 1) * (_factor - 1);

            

        }
        for (int i = 0; i < _addAmount; i++)
        {
            Instantiate(_playerPrefab, GameManager.Instance.player.transform);

        }
    }

    private void OnEnable()
    {
       
        _tmpro.text = "+" + _addAmount.ToString();
        if (_factor > 1)
        {
            _tmpro.text = "x" + _factor.ToString();
        }

    }
}
