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
        //if (Input.GetKeyDown("space")) {
            GameObject thePlayer = GameObject.Find("Player");
            Player playerScript = thePlayer.GetComponent<Player>();

            if(playerScript.touch == true){
                menu.SetActive(true);
            }
            else{
                //isShowing = !isShowing;
                menu.SetActive(false);
            }
    }
}