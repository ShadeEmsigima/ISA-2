using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[EventHandlerInfo("VarChecker", "VarChecker", "Executes a block if a scertian var equals something.")]

public class checkForVar : EventHandler
{

    public float requiredMin;
    public float requiredMax;

    void Update()
    {
        if(requiredMin >= TestMindset.testPlayerMindset && requiredMax <= TestMindset.testPlayerMindset)
        {
            ExecuteBlock();
            Debug.Log("VARCHECKER WORKS YAY");
        }
            
    }

}
