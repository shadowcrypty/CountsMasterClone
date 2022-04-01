using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suicider : MonoBehaviour,IKillable
{
    [SerializeField]
    private GameObject _destroyEffect;
    public void KillMe()
    {
        Instantiate(_destroyEffect,transform);

        GetComponent<Collider>().enabled = false;
        //destroying objects
        Destroy(transform.gameObject,0.15f);
        
    }
}
