using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayCanvas : MonoBehaviour {
  
    public GameObject menu; // Assign in inspector
 
    void Start()
    {
        menu.SetActive(false);
    }

    void Update() {
        // show canvas if space is pressed
        GameObject thePlayer = GameObject.Find("Player");
        Player playerScript = thePlayer.GetComponent<Player>();

        // if cutterVar > 0, hide menu
        GameObject invent = GameObject.Find("Inventory");
        InventorySystem inventorySystem = invent.GetComponent<InventorySystem>();

        if(playerScript.touch == true && inventorySystem.boltcuttersVar == 0){
            menu.SetActive(true);
        }
        else{
            //isShowing = !isShowing;
            menu.SetActive(false);
        }
    }
}