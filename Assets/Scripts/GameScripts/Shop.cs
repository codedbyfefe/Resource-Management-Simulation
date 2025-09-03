using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    // Creating variables that will be used as refrence 
    // in this script
    public Text Chickens;
    public Text Tomatoseeds;
    public Text Potatoseeds;
    public Text Tomatoes;
    public Text Potatoes;

    public GameObject Chickencoop;

   


    
   private void Start()
    {
       
    }

    //This update function updates the ui text
    //after either a trade has been made or a crop has been planted
    void Update()
    {
        Chickens.text = "Chickens:"  + GameManager.Chickens;
        Tomatoseeds.text = "Tomatoseeds:"  + GameManager.tomatoseed;
        Potatoseeds.text = "Potatoseed:"  + GameManager.Potatoseed;
        Tomatoes.text = "Tomatoes:" + GameManager.Tomato;
        Potatoes.text = "Potatoes:" + GameManager.Potato;
    }


    //Creating a function for the trading of the items that are available
    // at the market 
    public void Trade(int Itemnum)
    {
        Debug.Log("Button is clicked");

        if(Itemnum== 3 && GameManager.Chickens>=1)
        {
            GameManager.Chickens -= 1;
            GameManager.tomatoseed += 3;
        }
        if (Itemnum == 2 && GameManager.Chickens >= 1)
        {
            GameManager.Chickens -= 1;
            GameManager.Potatoseed += 3;
        }
        if (Itemnum == 1 && GameManager.Tomato >= 6)
        {
            GameManager.Tomato -= 6;
            GameManager.Potato -= 6;
            GameManager.Chickens += 1;
            
        }
        if(Itemnum == 4 && GameManager.Chickens >= 2)
        {
            GameManager.Chickens -= 2;
            GameManager.Potato -= 10;
            GameManager.Tomato -= 10;

            Build();
        }
    }

    //This function is called after a trade has been made
    // it spawns a chicken coop after trade has been successful
    public void Build()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(Chickencoop, new Vector3(0, 5, 0), Quaternion.identity);

        Debug.Log("Chicken coop spawned.");
    }
}
