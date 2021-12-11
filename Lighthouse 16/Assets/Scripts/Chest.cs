using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    public GameObject textCanvas;
    public Text newText;

    void Start()
    {
        textCanvas.SetActive(false);
    }

    // click on the chest and the reel appears and the chest opens
    void OnMouseDown()
    {
        // retrieve inventorySystem script
        GameObject invent = GameObject.Find("Inventory");
        InventorySystem inventorySystem = invent.GetComponent<InventorySystem>();

        if(inventorySystem.keyVar == 0){
            // show canvas text
            StartCoroutine(RemoveAfterSeconds(4, textCanvas));
        }
        else if(inventorySystem.keyVar == 1 && inventorySystem.reelVar == 0){
            // change chest position
            var transform = this.GetComponent<Transform>();
            transform.Rotate(-45.0f, 0.0f, 0.0f);

            // show reel, hide key in inventory
            inventorySystem.reelVar = 1;
            inventorySystem.keyVar = 2;

            // change the text
            newText.text = "A reel was inside.";
            newText.enabled = true;
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