using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    
    public static bool isSprinting,isFighting;

    public void Update()
    {


        animator.SetBool("Fight",isFighting);
        animator.SetBool("Sprint",isSprinting);
    }


}
