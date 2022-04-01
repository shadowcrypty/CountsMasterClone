using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player :  HumanoidBase
{
   

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Killer"))
        {

            if (other.GetComponent<IKillable>() != null)
            {
                other.GetComponent<IKillable>().KillMe();
                GetComponentInChildren<Animator>().SetBool("Fight",true);
            }
            killable.KillMe();

        }
    }


}
