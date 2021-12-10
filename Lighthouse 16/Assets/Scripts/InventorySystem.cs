using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public GameObject hotBar;
    public GameObject key;
    public GameObject reel;
    public GameObject telescope;
    public GameObject boltcutters;

    public int keyVar = 0;
    public int reelVar = 0;
    public int telescopeVar = 0;
    public int boltcuttersVar = 0;
    public int hideCanvas = 0;
 
    // Start is called before the first frame update
    void Start()
    {
        hotBar.SetActive(true);
        key.SetActive(false);
        reel.SetActive(false);
        telescope.SetActive(false);
        boltcutters.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // "hide" canvas if the CryingStatue Canvas is on
        if(hideCanvas == 0){
            // show hotbar
            hotBar.SetActive(true);

            // show/remove key
            if(keyVar == 1){
                key.SetActive(true);
            } else if(keyVar == 2){
                key.SetActive(false);
            }

            // show/remove reel
            if(reelVar == 1){
                reel.SetActive(true);
            } else if(reelVar == 2){
                reel.SetActive(false);
            }

            // telescope always stays active after being found
            if(telescopeVar == 1){
                telescope.SetActive(true);
            }

            // boltcutters always stay active after being found
            if(boltcuttersVar == 1){
                boltcutters.SetActive(true);
            }
        }
        else{
            hotBar.SetActive(false);
            key.SetActive(false);
            reel.SetActive(false);
            telescope.SetActive(false);
            boltcutters.SetActive(false);
        }
    }
}
