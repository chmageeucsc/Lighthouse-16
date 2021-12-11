using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headstones : MonoBehaviour
{   
    public GameObject textCanvas;
    public static int touch = 0;

    void Start(){
        textCanvas.SetActive(false);
    }

    // click on the chest and the reel appears and the chest opens
    void OnMouseDown()
    {
        if(touch == 0){
            // iterate touch so that if the canvas is on, touching the other gravestones wont make it reapper
            touch = 1;

            // show canvas text
            StartCoroutine(RemoveAfterSeconds(4, textCanvas));
        }
    }   

    IEnumerator RemoveAfterSeconds (int seconds, GameObject obj){
        obj.SetActive(true);
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
        touch = 0;
    }
}