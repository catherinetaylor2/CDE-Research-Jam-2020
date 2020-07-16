using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class onButtonClick : MonoBehaviour
{

    public Button button1;
    public GameObject cam;
    ARCameraManager arCam;

    // Start is called before the first frame update
    void Start()
    {
        arCam = cam.GetComponent<ARCameraManager>();
        // print(arCam == null);
        // arCam.requestedFacingDirection = CameraFacingDirection.World;
        // print(arCam.requestedFacingDirection);
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
            // arCam.requestedFacingDirection = CameraFacingDirection.World;
             SceneManager.LoadScene("PlaceObject", LoadSceneMode.Single);
        }

    }

    void OnDisable()
    {
        //Un-Register Button Events
        button1.onClick.RemoveAllListeners();
    }
}
