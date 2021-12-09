using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // click on the bucket and the key appears and the bucket falls
    void OnMouseDown(){
        // retrieve  inventorySystem script
        GameObject invent = GameObject.Find("Inventory");
        InventorySystem inventorySystem = invent.GetComponent<InventorySystem>();

        if(inventorySystem.keyVar == 0){
            // change bucket position
            var transform = this.GetComponent<Transform>();
            transform.position = new Vector3(14.0f, -0.8f, -2.0f);
            transform.Rotate(90.0f, 0.0f, -45.0f);

            // show key in inventory
            inventorySystem.keyVar = 1;

        }
    }   
}
