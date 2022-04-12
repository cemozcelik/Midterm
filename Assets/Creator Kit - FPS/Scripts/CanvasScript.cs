using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CanvasScript : MonoBehaviour

{
    public GameObject myCanvas;
    
    public void Uodate()
    {
        OnTriggerEnter();
    }

    void OnTriggerEnter()
    {
        myCanvas.SetActive(true);
    }

    void OnTriggerExit()
    {
        myCanvas.SetActive(false);
    }
}