using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayCanvas : MonoBehaviour {
  
    public GameObject menu; // Assign in inspector
    public GameObject hotbar; // Assign in inspector
 
    void Start()
    {
        menu.SetActive(false);
    }

    void Update() {
        // find player
        GameObject thePlayer = GameObject.Find("Player");
        Player playerScript = thePlayer.GetComponent<Player>();

        // find inventory script
        GameObject invent = GameObject.Find("Inventory");
        InventorySystem inventorySystem = invent.GetComponent<InventorySystem>();

        // show canvas if space is pressed
        if(playerScript.touch == true && inventorySystem.boltcuttersVar == 0){
            menu.SetActive(true);
            inventorySystem.hideCanvas = 1;
        }
        else{
            //isShowing = !isShowing;
            menu.SetActive(false);
            inventorySystem.hideCanvas = 0;
        }
    }
}