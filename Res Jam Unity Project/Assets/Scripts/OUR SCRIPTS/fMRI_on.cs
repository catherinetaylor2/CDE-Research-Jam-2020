using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fMRI_on : MonoBehaviour
{

    public GameObject brain1, brain2, brain3, brain4, brain5, brain6, activeRegion1, activeRegion2;
	public GameObject brain1_1, brain1_2, brain1_3, brain1_4, brain1_5, brain1_6;
    public Button button1;

    private activeData active_data;

    // Start is called before the first frame update
    void Start()
    {
        active_data = FindObjectOfType<activeData>();
    }

    // Update is called once per frame
    void Update()
    {
        button1.onClick.AddListener(test);
    }

    void test(){

        active_data.setActive();

        brain1.SetActive(true);
        brain2.SetActive(true);
        brain3.SetActive(true);
        brain4.SetActive(true);
        brain5.SetActive(true);
        brain6.SetActive(true);
        activeRegion1.SetActive(true);
        activeRegion2.SetActive(true);
        brain1_1.SetActive(false);
        brain1_2.SetActive(false);
        brain1_3.SetActive(false);
        brain1_4.SetActive(false);
        brain1_5.SetActive(false);
        brain1_6.SetActive(false);
    }

}
