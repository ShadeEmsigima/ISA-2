using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Fungus;

public class TestMindset : MonoBehaviour {

    //private Flowchart flowchart;
    public static float testPlayerMindset;

    // this is what the player needs to have at the start of the game:
    void Start()
    {
        testPlayerMindset = 0;
        Debug.Log("Player's mindset is now = " + testPlayerMindset);
    }
    
    // add points to the players mindset
   void Add()
   {
        testPlayerMindset += 1;
        Debug.Log("Player's mindset update = " + testPlayerMindset);
   }
    
    // subtract points from the players mindset
   void Subtract()
   {
        testPlayerMindset -= 1;
        Debug.Log("Player's mindset update = " + testPlayerMindset);
   }

}
