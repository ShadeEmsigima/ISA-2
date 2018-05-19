using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// for this code I used the following tutorial: https://www.youtube.com/watch?v=dJB07ZSiW7k
public class MaterialChanger : MonoBehaviour
{

    public Material[] material;// here is where u choose from mats
    //this is gonna acces ur game object
    private Renderer rend;
    private float mindset;
    public bool isHuman;


    void Start()
    {
        rend = GetComponent<Renderer>(); //were making the our renderer the game object's renderer itself
        rend.enabled = true; //making sure its enabled in case it not
        //setting the mat of the renderer, grabbing the material uve set the number of from the array
        rend.sharedMaterial = material[4];//starting mat is always neutral
        Debug.Log("MATERIAL CHANGER - The player mindset is: " + mindset);
        // help: https://answers.unity.com/questions/699565/how-to-get-a-variable-value-from-another-scriptc.html
    }

    private void Update()
    {
        mindset = TestMindset.testPlayerMindset;
        

        // wordt zwart
        if (mindset < 0)
        {
            rend.sharedMaterial = material[0];

        }

        //blijf wit
        if (mindset == 0)
        {
            rend.sharedMaterial = material[4];

        }

        //wordt geel
        if (mindset > 0)
        {
            rend.sharedMaterial = material[8];
        }
    }
    private void OnCollisionEnter2D(Collision2D col) //col variable is the object the holder of this script will be hitting
    // so whe our object colides, this is whats gonna happen:
    {
        if (col.gameObject.tag == "Player")
        {
            if (isHuman == true)
            {
                Debug.Log("This is/are a human(s)");
            }
            else
            {
                Debug.Log("This is an object");
            }
        }
    }
}

