using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cellar : MonoBehaviour
{
    // Start is called before the first frame update
    void onMouseDown()
    {
        GameObject invent = GameObject.Find("Inventory");
        InventorySystem inventorySystem = invent.GetComponent<InventorySystem>();
        if(inventorySystem.boltcuttersVar == 1){
            inventorySystem.boltcuttersVar = 2;
            //how are we ending this?
        }
    }

    
}
