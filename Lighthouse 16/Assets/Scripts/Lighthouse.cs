using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighthouse : MonoBehaviour
{
    public GameObject textCanvas;
 
    void Start()
    {
        textCanvas.SetActive(false);
    }

    // click on the chest and the reel appears and the chest opens
    void OnMouseDown(){
        // show canvas text
        StartCoroutine(RemoveAfterSeconds(4, textCanvas));
    }   

    IEnumerator RemoveAfterSeconds (int seconds, GameObject obj){
        obj.SetActive(true);
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }
}
