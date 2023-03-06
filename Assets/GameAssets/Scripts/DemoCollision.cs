using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("On Collision Enter");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("On Collision Stay");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("On Collision Exit");
    }
}
