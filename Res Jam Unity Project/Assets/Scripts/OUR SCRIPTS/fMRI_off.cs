using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fMRI_off : MonoBehaviour
{

    public GameObject brain1, brain2, brain3, brain4, brain5, brain6, activeRegion1, activeRegion2;
	public GameObject brain1_1, brain1_2, brain1_3, brain1_4, brain1_5, brain1_6;
    public Button button1;

    private activeData active_data;

    // Start is called before the first frame update
    void Start(){
        active_data = FindObjectOfType<activeData>();
    }

    // Update is called once per frame
    void Update()
    {
        button1.onClick.AddListener(test);
    }

    void test()
    {

        active_data.setOff();

        brain1.SetActive(false);
        brain2.SetActive(false);
        brain3.SetActive(false);
        brain4.SetActive(false);
        brain5.SetActive(false);
        brain6.SetActive(false);
        activeRegion1.SetActive(false);
        activeRegion2.SetActive(false);
        brain1_1.SetActive(true);
        brain1_2.SetActive(true);
        brain1_3.SetActive(true);
        brain1_4.SetActive(true);
        brain1_5.SetActive(true);
        brain1_6.SetActive(true);
    }

}
