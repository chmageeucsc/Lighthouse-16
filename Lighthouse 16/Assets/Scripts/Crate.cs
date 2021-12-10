using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{   
    public GameObject fog;

    // click on the chest and the reel appears and the chest opens
    void OnMouseDown(){
        // retrieve inventorySystem script
        GameObject invent = GameObject.Find("Inventory");
        InventorySystem inventorySystem = invent.GetComponent<InventorySystem>();

        if(inventorySystem.reelVar == 2 && inventorySystem.telescopeVar == 0){
            // show telescope
            inventorySystem.telescopeVar = 1;

            // stop fog
            fog.SetActive(false);
        }
    }   
}
