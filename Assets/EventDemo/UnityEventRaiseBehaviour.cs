using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class MyEvent : UnityEvent<string, GameObject>
{
    // define the event - inherit from Unity event with a string and game object parameter
    // the parameters can be anything you need, e.g. int, float, etc
}

public class UnityEventRaiseBehaviour : MonoBehaviour
{
    // Define event
    public MyEvent TestEvent;

    public void sendTheMessage(string inText, GameObject sender)
    {
        TestEvent.Invoke(inText, sender);
    }
}