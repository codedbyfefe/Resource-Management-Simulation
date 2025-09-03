using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The following code script does not belong to me. Credit: Silverlybee
//Coding scripts can be found on github https://github.com/silverlybee/farm-game-tutorial

[CreateAssetMenu(fileName = "New Crop", menuName = "Crop")]

public class CropObjects : ScriptableObject
{
    public string cropName;
    public Sprite[] cropstages;
    public float timeofstage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
