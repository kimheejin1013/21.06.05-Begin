using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputMessage : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("<b>Win!</b>");
    }

}
