using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanoidBase : MonoBehaviour
{
    protected IKillable killable;

    private void Start()
    {
        killable = GetComponent<IKillable>();
    }
}
