using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class CustomTriggerEnter : MonoBehaviour
{
    public UnityEvent on_trigger_enter_custom;

    void OnTriggerEnter()
    {
        on_trigger_enter_custom.Invoke();
    }

}
