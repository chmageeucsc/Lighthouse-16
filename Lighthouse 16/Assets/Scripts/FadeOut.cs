using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Fade;

    public void Fading(){
        Fade.GetComponent<Animation>().Play("FadeAnimation");
    }
}
