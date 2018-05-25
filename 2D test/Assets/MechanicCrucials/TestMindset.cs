using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMindset : MonoBehaviour {

    //private Flowchart flowchart;
    public static float testPlayerMindset;
    public int flowMindset;

    // this is what the player needs to have at the start of the game:
    void Start()
    {   
        // maximum mindset = 8
        // minimum mindset = -8
        testPlayerMindset = 0;
        Fungus.Flowchart.BroadcastFungusMessage(testPlayerMindset.ToString());
        Debug.Log("Player's mindset is now = " + testPlayerMindset + " Current fungus message = " + testPlayerMindset.ToString());
    }

    // add points to the players mindset
    void Add()
   {
        testPlayerMindset += 1;
        Fungus.Flowchart.BroadcastFungusMessage(testPlayerMindset.ToString());
        Debug.Log("Player's mindset went up and is now= " + testPlayerMindset + " Current fungus message = " + testPlayerMindset.ToString());
   }
    
    // subtract points from the players mindset
   void Subtract()
   {
        testPlayerMindset -= 1;
        Fungus.Flowchart.BroadcastFungusMessage(testPlayerMindset.ToString());
        Debug.Log("Player's mindset went down and is now = " + testPlayerMindset + " Current fungus message = " + testPlayerMindset.ToString());
    }

}
