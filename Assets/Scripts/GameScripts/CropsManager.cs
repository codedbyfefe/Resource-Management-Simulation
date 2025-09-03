using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// The following code script does not belong to me. Credit: Silverlybee
//Coding scripts can be found on github https://github.com/silverlybee/farm-game-tutorial
// Some changes have been added by Ofentse Magabeane

public class CropsManager : MonoBehaviour
{
    //Creating variables that will be refrenced in the script
    bool isPlanted = false;
    public SpriteRenderer crop;
    public Text ui;

    

    int cropstage = 0;
    float timer;

    public CropObjects selectedCrop;

    
    void Start()
    {

    }

    // This update function updates the stages of the crop after it has been planted
    void Update()
    {
        if(isPlanted)
        {
            timer -= Time.deltaTime;

            if(timer<0 && cropstage<selectedCrop.cropstages.Length-1)
            {
                timer = selectedCrop.timeofstage;
                cropstage++;
                Updatecrop();
            }    
        }

        

    }

    // This function checks if the crop has been planted or harvested
   private void OnMouseDown()
    {
        if(isPlanted)
        {
            if(cropstage ==selectedCrop.cropstages.Length - 1)
            {
                Harvestcrop();
            }
            
        }
        else
        {
            Plant();
        }
        Debug.Log("Plot is clicked");

       
    }

    //The Harvest crop function harvests the crop after the 
    // plant growth cycle has ended
    void Harvestcrop()
    {
        Debug.Log("Harvested");
            isPlanted = false;
        crop.gameObject.SetActive(false);

        if (selectedCrop= selectedCrop)
        {
            GameManager.Tomato += 1;
        }
        else if(selectedCrop=selectedCrop)
        {
            GameManager.Potato += 1;
        }
        


    }

    //This functions plants the crop on an empty plot of land
    void Plant()
    {
        Debug.Log("Planted");
            isPlanted = true;
        cropstage = 0;
        Updatecrop();
        timer = selectedCrop.timeofstage;
        crop.gameObject.SetActive(true);

        if(selectedCrop= selectedCrop)
        {
            GameManager.tomatoseed -= 1;
        }
        else if(selectedCrop=selectedCrop)
        {
            GameManager.Potatoseed -= 1;
        }
    }
    
    //This function updates the crop growth sprote after it has been planted
    void Updatecrop()
    {
        crop.sprite = selectedCrop.cropstages[cropstage];
    }

   
}

