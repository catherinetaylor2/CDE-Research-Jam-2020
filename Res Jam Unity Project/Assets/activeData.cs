using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeData : MonoBehaviour
{

    public bool fMRIActive = false;

    public GameObject fMRIButtons, normButtons;

    public void setActive(){
        fMRIActive = true;
        fMRIButtons.SetActive(true);
        normButtons.SetActive(false);
    }

    public void setOff(){
        fMRIActive = false;
        fMRIButtons.SetActive(false);
        normButtons.SetActive(true);

    }

}
