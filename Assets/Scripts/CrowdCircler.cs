using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CrowdCircler : MonoBehaviour
{
    public GameObject target;

    private void Start()
    {
        target = gameObject;
    }
    void Update()
    {
        
        for (int i = 1; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).GetComponent<NavMeshAgent>()==null)
            {
                return;
            }
            if (target==null)
            {
                target = gameObject;
            }
            transform.GetChild(i).GetComponent<NavMeshAgent>().SetDestination(target.transform.position);
            // rotation stabileze
            transform.GetChild(i).rotation = Quaternion.identity;
        }
        
    }
}
