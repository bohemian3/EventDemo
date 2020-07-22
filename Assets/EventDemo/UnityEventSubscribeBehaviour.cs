using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UnityEventSubscribeBehaviour : MonoBehaviour
{
    public UnityEngine.UI.InputField msgToSend;
    public UnityEventRaiseBehaviour eventRaiseBehaviour;
    public Text displayMessage;
    public MyEvent TestEvent2;
    public UnityEventRaiseBehaviour dispatcher;
    public GameObject Avatar;
    public Text AvatarNameHeader;

    private void Start()
    {
        AvatarNameHeader.text = "<b>" +  Avatar.name + "</b>";

        if (dispatcher == null)
        {
            dispatcher = (UnityEventRaiseBehaviour)GameObject.Find("Dispatcher").GetComponent(typeof(UnityEventRaiseBehaviour));
        }

        // has the event been instantiated, if not go ahead and do it
        if (eventRaiseBehaviour == null)
        {
            eventRaiseBehaviour = GameObject.FindObjectOfType<UnityEventRaiseBehaviour>();
        }

        if (eventRaiseBehaviour.TestEvent == null)
        {
            eventRaiseBehaviour.TestEvent = new MyEvent();
        }

        // subscribe to the event
        eventRaiseBehaviour.TestEvent.AddListener(message_Handler);
    }

    // event handler
    private void message_Handler(string argument, GameObject sender)
    {
        if (sender.name != Avatar.name)
        {
            displayMessage.text = sender.name + " says : " + argument ;
            msgToSend.text = "";
        } else
        {
            displayMessage.text = "";
        }
    }

    public void sendMyMessage()
    {
        dispatcher.sendTheMessage(msgToSend.text, this.gameObject);
    }
}
