using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroy : MonoBehaviour
{

    public Button button1;
	public GameObject buttonBye;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        button1.onClick.AddListener(remove);
    }

	void remove()

{
	buttonBye.SetActive(false);
}

}


