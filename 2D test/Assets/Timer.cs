using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[EventHandlerInfo("Timers", "SimpleTimer", "Executes a block after an amount of time has elapsed")]

public class simpleTimer : EventHandler {

    public float duration;

	// Use this for initialization
	void Start () {
        Invoke("TimerExpired", duration);
	}

    void TimerExpired()
    {
        ExecuteBlock();
    }
}
