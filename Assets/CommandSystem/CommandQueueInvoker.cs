using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandQueueInvoker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExecuteNextCommand());    
    }

    private IEnumerator ExecuteNextCommand()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            CommandQueue.Instance.DequeueCommand();
        }
    }
}
