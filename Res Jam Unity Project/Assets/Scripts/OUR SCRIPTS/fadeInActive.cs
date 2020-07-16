using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeInActive : MonoBehaviour
{

	public GameObject brain1, brain2, brain3, brain4, brain5, brain6;

    // Start is called before the first frame update
    void Start()
    {
	brain1.SetActive(false);
	brain2.SetActive(false);
	brain3.SetActive(false);
	brain4.SetActive(false);
	brain5.SetActive(false);
	brain6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
	 if (Input.GetKeyDown (KeyCode.A) ) {
	brain1.SetActive(true);}
	 if (Input.GetKeyDown (KeyCode.A) ) {
	brain2.SetActive(true);}
	 if (Input.GetKeyDown (KeyCode.A) ) {
	brain3.SetActive(true);}
	 if (Input.GetKeyDown (KeyCode.A) ) {
	brain4.SetActive(true);}
	 if (Input.GetKeyDown (KeyCode.A) ) {
	brain5.SetActive(true);}
	 if (Input.GetKeyDown (KeyCode.A) ) {
	brain6.SetActive(true);
    }
}

}
