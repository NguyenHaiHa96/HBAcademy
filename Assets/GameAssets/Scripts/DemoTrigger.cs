using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoTrigger : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void Start()
    {
        Debug.Log("Start");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("On Trigger Enter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("On Trigger Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("On Trigger Exit");
    } 
}
