using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CanvasScript : MonoBehaviour

{
    public Text myText;
    public GameObject myCanvas;
    
    public void Update()
    {
        
    }

    public void OnTriggerEnter(Collider self)
    {
        //if (self.name == collider1.name)
        //{
        //    Debug.Log("asdaaaaaaasd");
        //}
        if (this.name=="collider")
        {
            myText.text = " Myocarditis - press E for the detailed information";
        }
        if (this.name == "collider2")
        {
            myText.text = "asdasdasdasd";
        }
        if (this.name == "collider3")
        {
            myText.text = "baban";
        }
        if (this.name == "collider4")
        {
            myText.text = "baban";
        }
        if (this.name == "collider5")
        {
            myText.text = "baban";
        }
        if (this.name == "collider6")
        {
            myText.text = "baban";
        }
        if (this.name == "collider7")
        {
            myText.text = "baban";
        }
        myCanvas.SetActive(true);
            
    }
    
    
    void OnTriggerExit()
    {
        myCanvas.SetActive(false);
    }
    

    
           
      
        
        


}