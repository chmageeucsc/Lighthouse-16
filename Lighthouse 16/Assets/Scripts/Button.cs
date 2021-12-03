using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour
{
    public Text Textfield;
    public int num1 = 0;
    public int num2 = 0;
    public int num3 = 0;

    public void SetText(string text){
        Textfield.text = text;
    }

    public void OnClicked(Button button)
    {
        //print(button.name);

        // check which button is pressed
        if(button.name == "1 Up"){
            num1 = NumAdd(num1);
        } else if(button.name == "1 Down"){
            num1 = NumSub(num1);
        } else if(button.name == "2 Up"){
            num2 = NumAdd(num2);
        } else if(button.name == "2 Down"){
            num2 = NumSub(num2);
        } else if(button.name == "3 Up"){
            num3 = NumAdd(num3);
        } else if(button.name == "3 Down"){
            num3 = NumSub(num3);
        } 
    }

    public int NumAdd(int num){
        if(num < 9){
            num = (num + 1);
        }
        print("add num: " +  num);
        return num;
    }

    public int NumSub(int num){
        if(num > 0){
            print("in bitch");
            num = (num - 1);
        }
        print("sub num: " +  num);
        return num;
    }

    void Update()
    {
        //EventSystem.current.currentSelectedGameObject.name; 
    }
}
