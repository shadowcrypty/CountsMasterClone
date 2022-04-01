using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CrowdCount : MonoBehaviour
{
    
    private void Update()
    {
        GetComponent<TextMeshProUGUI>().text = (transform.parent.parent.childCount-1).ToString();
    }

}
