using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FightZone : MonoBehaviour
{
    [SerializeField]
    UnityEvent _fightEvent;
    public static bool IsFighting;
    private void OnTriggerStay(Collider other)
    {
        if (transform.childCount == 1)
        {
            PlayerAnimation.isFighting = false;

            InputManager.Instance.MovePlayer();
            transform.gameObject.SetActive(false);
            other.GetComponentInParent<CrowdCircler>().target = null;

            return;

        }
        if (other.CompareTag("Player"))
        {
            //fight
            PlayerAnimation.isFighting = true;
            _fightEvent.Invoke();
 //           GetComponent<CrowdCircler>().target = other.gameObject;
            InputManager.Instance.StopPlayer();
            other.GetComponentInParent<CrowdCircler>().target = gameObject;

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (transform.childCount == 1)
        {
            InputManager.Instance.MovePlayer();
            transform.gameObject.SetActive(false);
            return;

        }
    }


}
