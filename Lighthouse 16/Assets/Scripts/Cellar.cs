using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cellar : MonoBehaviour
{
    public GameObject textCanvas;
    public Text newText;
 
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
            // change the text
            newText.text = "The cellar is unlocked.";
            newText.enabled = true;
            
            // show canvas text
            StartCoroutine(RemoveAfterSeconds(4, textCanvas));
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