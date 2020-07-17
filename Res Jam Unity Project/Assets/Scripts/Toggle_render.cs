using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle_render : MonoBehaviour
{
    public void toggle_visibility(){

        Renderer rend = gameObject.GetComponent<Renderer>();

        if (rend.enabled)
            rend.enabled = false;

        else 
            rend.enabled = true;
    }
}
