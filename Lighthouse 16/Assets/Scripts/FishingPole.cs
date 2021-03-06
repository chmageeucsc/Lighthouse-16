using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishingPole : MonoBehaviour
{
    public GameObject crate;
    public GameObject textCanvas;
    public Text newText;
    
    // Start is called before the first frame update
    void Start()
    {
        crate.SetActive(false);
        textCanvas.SetActive(false);
    }

    // click on the chest and the reel appears and the chest opens
    void OnMouseDown(){
        // retrieve inventorySystem script
        GameObject invent = GameObject.Find("Inventory");
        InventorySystem inventorySystem = invent.GetComponent<InventorySystem>();

        if(inventorySystem.reelVar == 0){
            // show canvas text
            StartCoroutine(RemoveAfterSeconds(4, textCanvas));
        }
        else if(inventorySystem.reelVar == 1 && inventorySystem.telescopeVar == 0){
            // show crate
            crate.SetActive(true);

            // hide reel
            inventorySystem.reelVar = 2;

            // change the text
            newText.text = "The fishing pole brings up a cage.";
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