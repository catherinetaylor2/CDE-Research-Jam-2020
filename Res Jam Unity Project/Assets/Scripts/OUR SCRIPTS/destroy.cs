using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroy : MonoBehaviour
{

    public Button button1;
	public GameObject buttonBye;
    public GameObject buttonOn;
    public GameObject buttonOff;
    public GameObject downloadPanel;

    // Start is called before the first frame update
    void Start()
    {
        buttonOn.SetActive(false);
        buttonOff.SetActive(false);
        downloadPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        button1.onClick.AddListener(remove);
    }

	void remove()

{
	buttonBye.SetActive(false);
    buttonOn.SetActive(true);
    buttonOff.SetActive(true);
    downloadPanel.SetActive(true);
}

}


