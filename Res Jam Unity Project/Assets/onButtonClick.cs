using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onButtonClick : MonoBehaviour
{

    public Button button1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable(){
        //Register Button Events
        button1.onClick.AddListener(() => buttonCallBack(button1));
    }

     private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == button1)
        {
            Debug.Log("Clicked: " + button1.name);
        }

    }

    void OnDisable()
    {
        //Un-Register Button Events
        button1.onClick.RemoveAllListeners();
    }
}
