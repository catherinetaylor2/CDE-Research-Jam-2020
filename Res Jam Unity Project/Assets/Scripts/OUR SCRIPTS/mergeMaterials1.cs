using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mergeMaterials1 : MonoBehaviour
{

	public GameObject brain1, brain2, brain3, brain4, brain5, brain6;

    // Start is called before the first frame update
    void Start()
    {
	brain1.SetActive(true);
	brain2.SetActive(true);
	brain3.SetActive(true);
	brain4.SetActive(true);
	brain5.SetActive(true);
	brain6.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
	 if (Input.GetKeyDown (KeyCode.A) ) {
	brain1.SetActive(false);}
	 if (Input.GetKeyDown (KeyCode.A) ) {
	brain2.SetActive(false);}
	 if (Input.GetKeyDown (KeyCode.A) ) {
	brain3.SetActive(false);}
	 if (Input.GetKeyDown (KeyCode.A) ) {
	brain4.SetActive(false);}
	 if (Input.GetKeyDown (KeyCode.A) ) {
	brain5.SetActive(false);}
	 if (Input.GetKeyDown (KeyCode.A) ) {
	brain6.SetActive(false);}
	 if (Input.GetKeyDown (KeyCode.S) ) {
	brain1.SetActive(true);}
	 if (Input.GetKeyDown (KeyCode.S) ) {
	brain2.SetActive(true);}
	 if (Input.GetKeyDown (KeyCode.S) ) {
	brain3.SetActive(true);}
	 if (Input.GetKeyDown (KeyCode.S) ) {
	brain4.SetActive(true);}
	 if (Input.GetKeyDown (KeyCode.S) ) {
	brain5.SetActive(true);}
	 if (Input.GetKeyDown (KeyCode.S) ) {
	brain6.SetActive(true);
    }
}

}
