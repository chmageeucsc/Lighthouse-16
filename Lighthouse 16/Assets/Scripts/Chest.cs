using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // click on the chest and the reel appears and the chest opens
    void OnMouseDown(){
        // retrieve inventorySystem script
        GameObject invent = GameObject.Find("Inventory");
        InventorySystem inventorySystem = invent.GetComponent<InventorySystem>();

        if(inventorySystem.keyVar == 1 && inventorySystem.reelVar == 0){
            // change chest position
            Debug.Log("Clicked");
            var transform = this.GetComponent<Transform>();
            transform.Rotate(-45.0f, 0.0f, 0.0f);

            // show key in inventory
            inventorySystem.reelVar = 1;
            inventorySystem.keyVar = 2;

        }
    }   
}