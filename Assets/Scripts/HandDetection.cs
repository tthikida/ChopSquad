using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandDetection : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out ClearCounter clearCounter))
        {
            Debug.Log("Touching Clear Counter");
        }
        else
        {
            Debug.Log(other.name);
        }
    }
}
