using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {
    public bool isBlack;


    private void Start () {
        Debug.Log("Game has started");
	}

    // if you touch another object thats tagged Interactable:
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("You've touched an interactable!");
            if (isBlack == true)
                //GetComponent<Shader>
                Debug.Log("Black is true");

            //maak UI aan die vraag of je t geel of zwart vind
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
