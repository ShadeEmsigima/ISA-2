using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[EventHandlerInfo("Li's Event handlers", "Read Mindset", "Executes a block if mindset is at appropiate amount")]

public class DialogueChanger : EventHandler
{
    private float flowchartMindset;

    void Start()
    {
        //flowchartMindset = TestMindset.testPlayerMindset;
    }

    void TimerExpired()
    {
        ExecuteBlock();
    }
}
