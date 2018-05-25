using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// for this code I used the following tutorial: https://www.youtube.com/watch?v=dJB07ZSiW7k
public class MaterialChanger : MonoBehaviour
{
    private Renderer rend;
    private float mindset;

    public Material[] material;// here is where u choose from mats this is gonna acces ur game object
    public bool isHuman;
    public bool isAlwaysBlack;
    public bool isAlwaysYellow;
    public bool isBoth;


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
      

        if (isAlwaysBlack == true)
        {
            // set color to black 1
            if (mindset < 0 && mindset > -3)
            {
                rend.sharedMaterial = material[3];
            }

            // set color to black 2
            if (mindset < -2 && mindset > -5)
            {
                rend.sharedMaterial = material[2];
            }

            // set color to black 3
            if (mindset < -4 && mindset > -7)
            {
                rend.sharedMaterial = material[1];
            }

            // set color to black 4
            if (mindset < -6 && mindset > -9)
            {
                rend.sharedMaterial = material[0];
            }
        } 
        
        // set color to neutral
        if (mindset == 0)
        {
            rend.sharedMaterial = material[4];
        }

        if (isAlwaysYellow == true)
        {
            // set color to yellow 1
            if (mindset > 0 && mindset < 3)
            {
                rend.sharedMaterial = material[5];
            }

            // set color to yellow 2
            if (mindset > 2 && mindset < 5)
            {
                rend.sharedMaterial = material[6];
            }

            // set color to yellow 3
            if (mindset > 4 && mindset < 7)
            {
                rend.sharedMaterial = material[7];
            }

            // set color to yellow 4
            if (mindset > 6 && mindset < 9)
            {
                rend.sharedMaterial = material[8];
            }
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

