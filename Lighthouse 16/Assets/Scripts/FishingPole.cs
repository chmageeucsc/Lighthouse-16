using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingPole : MonoBehaviour
{
    public GameObject crate;
    // Start is called before the first frame update
    void Start()
    {
        crate.SetActive(false);
    }

    // click on the chest and the reel appears and the chest opens
    void OnMouseDown(){
        // retrieve inventorySystem script
        GameObject invent = GameObject.Find("Inventory");
        InventorySystem inventorySystem = invent.GetComponent<InventorySystem>();

        if(inventorySystem.reelVar == 1 && inventorySystem.telescopeVar == 0){
            // show crate
            crate.SetActive(true);

            // hide reel
            inventorySystem.reelVar = 2;
        }
    }   
}