using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour
{
    public Text Textfield1;
    public Text Textfield2;
    public Text Textfield3;
    public int num1 = 0;
    public int num2 = 0;
    public int num3 = 0;

    public void OnClicked(Button button)
    {
        // find buttons
        Textfield1 = GameObject.Find("Cross Text").GetComponent<Text> ();
        Textfield2 = GameObject.Find("Wing Text").GetComponent<Text> ();
        Textfield3 = GameObject.Find("Rock Text").GetComponent<Text> ();

        // check which button is pressed
        if(button.name == "1 Up"){
            // add to total
            num1 = NumAdd(num1);
            // send to text box
            Textfield1.text = num1.ToString();
        } else if(button.name == "1 Down"){
            num1 = NumSub(num1);
            Textfield1.text = num1.ToString();
        } else if(button.name == "2 Up"){
            num2 = NumAdd(num2);
            Textfield2.text = num2.ToString();
        } else if(button.name == "2 Down"){
            num2 = NumSub(num2);
            Textfield2.text = num2.ToString();
        } else if(button.name == "3 Up"){
            num3 = NumAdd(num3);
            Textfield3.text = num3.ToString();
        } else if(button.name == "3 Down"){
            num3 = NumSub(num3);
            Textfield3.text = num3.ToString();
        } 
    }

    public int NumAdd(int num){
        if(num < 9){
            num = (num + 1);
        }
        return num;
    }

    public int NumSub(int num){
        if(num > 0){
            num = (num - 1);
        }
        return num;
    }

    void Update()
    {
        
    }
}
