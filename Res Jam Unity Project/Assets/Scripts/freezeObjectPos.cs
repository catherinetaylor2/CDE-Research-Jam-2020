using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class freezeObjectPos : MonoBehaviour
{
    ARPlaceObject placeObj;
    public Button button1;
    public GameObject interactionButtons;
    // Start is called before the first frame update
    void Start(){
        placeObj = FindObjectOfType<ARPlaceObject>();
        interactionButtons.SetActive(false);
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
            placeObj.isPlaced();
            interactionButtons.SetActive(true);
            gameObject.SetActive(false);
        }

    }

    void OnDisable()
    {
        //Un-Register Button Events
        button1.onClick.RemoveAllListeners();
    }
}
