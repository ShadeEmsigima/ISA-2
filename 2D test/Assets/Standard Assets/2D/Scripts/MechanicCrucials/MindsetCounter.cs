using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MindsetCounter : MonoBehaviour {

    public static float playerMindset;

    // this is what the player needs to have at the start of the game:
	void Start () {
        playerMindset = 0;
        Debug.Log("Player's mindset = "+playerMindset);
	}
	
	void Update () {

	}
}
