using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoFunction : MonoBehaviour
{
    public bool IsInUse;
    public bool UseCoroutine;

    private float delayTime = 4f;

    private void Start()
    {
        if (IsInUse)
        {
            if (UseCoroutine)
            {
                StartCoroutine(CoroutineDelayCall());
            }
            else
            {
                Invoke(nameof(InvokeDelayCall), delayTime);
            }
        }
    }

    private IEnumerator CoroutineDelayCall()
    {
        yield return delayTime;
        Debug.Log("Delay call Coroutine");
    }

    private void InvokeDelayCall()
    {
        Debug.Log("Delay call Invoke");
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) 
        {
            Debug.Log("Space pressed");
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left mouse pressed");
        }
    }
}
