using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GateTrigger : MonoBehaviour
{
    [SerializeField]
    UnityEvent _gateEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.parent.transform.gameObject.SetActive(false);
            _gateEvent.Invoke();
        }
    }
}
