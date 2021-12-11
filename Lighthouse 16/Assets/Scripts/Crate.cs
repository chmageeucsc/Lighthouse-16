using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{   
    public GameObject fog;
    public GameObject textCanvas;

    void Start(){
        textCanvas.SetActive(false);
    }

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
        
        if(inventorySystem.telescopeVar == 1){
            // show canvas text
            StartCoroutine(RemoveAfterSeconds(4, textCanvas));
        }
    }   

    IEnumerator RemoveAfterSeconds (int seconds, GameObject obj){
        obj.SetActive(true);
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }
}
