using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cellar : MonoBehaviour
{
    public GameObject textCanvas;
 
    void Start()
    {
        textCanvas.SetActive(false);
    }

    // click on the chest and the reel appears and the chest opens
    void OnMouseDown(){
        // retrieve inventorySystem script
        GameObject invent = GameObject.Find("Inventory");
        InventorySystem inventorySystem = invent.GetComponent<InventorySystem>();

        // if players have the boltcutters
        if(inventorySystem.boltcuttersVar == 1){
            // hide canvas text
            textCanvas.SetActive(false);
        } else{
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
