using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ChatHistory : MonoBehaviour
{
    public UnityEventRaiseBehaviour eventRaiseBehaviour;
    public Text chatHistory;
    private LinkedList<string> _chatHistory = new LinkedList<string>();

    private void Start()
    {
        if (eventRaiseBehaviour == null)
        {
            eventRaiseBehaviour = GameObject.FindObjectOfType<UnityEventRaiseBehaviour>();
        }

        if (eventRaiseBehaviour.TestEvent == null)
        {
            eventRaiseBehaviour.TestEvent = new MyEvent();
        }

        // subscribe to the event
        eventRaiseBehaviour.TestEvent.AddListener(updateChat_Handler);
    }

    private void updateChat_Handler(string inMessage, GameObject inObj)
    {
        _chatHistory.AddLast(inObj.name + " : " + inMessage);

        if (_chatHistory.Count > 10)
        {
            _chatHistory.RemoveFirst();
        }

        chatHistory.text = "";
        int checklastEntry = 1;

        foreach(string s in _chatHistory)
        {
            if (checklastEntry == _chatHistory.Count) chatHistory.text += "<b>";
            chatHistory.text += s + "\n";
            if (checklastEntry == _chatHistory.Count) chatHistory.text += "</b>";
            checklastEntry += 1;
        }
    }

}
