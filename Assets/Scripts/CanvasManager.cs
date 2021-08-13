using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{

  
    public GameObject task;
    //public GameObject inputField;
    //public int[] inputFieldTasks;
    //public string courseNumberString = "3840U";

    private Color32 White = new Color32(255, 255, 255, 255);
    private Color32 Green = new Color32(229, 227, 255, 255);



    public void kaltura()
    {

        SceneManager.LoadScene("Kaltura");
    }

    public void google()
    {
        SceneManager.LoadScene("Google");
    }

    public void zoom()
    {
        SceneManager.LoadScene("Zoom");
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void connect()
    {
        SceneManager.LoadScene("Connecting");
    }

    public void classview()
    {
        SceneManager.LoadScene("Classview");
    }

    //Turns off Object (Sets it to inactive)
    public void objectOff(GameObject gameObject)
    {
            gameObject.SetActive(false);
    }





    //Sets the Objects colour to Green
    public void buttongreen(GameObject button)
    {

        button.GetComponent<Image>().color = Green;

    }


    //Toggles the colour of the button from green and white
    public void toggleButtonColour(GameObject button)
    {
        if (button.GetComponent<Image>().color == White)
        {
            button.GetComponent<Image>().color = Green;
        }
        else
        {
            button.GetComponent<Image>().color = White;
        }
    }

    //Sets the Objects colour to white
    public void buttonwhite(GameObject button)
    {
        button.GetComponent<Image>().color = White;

    }



    //Sets the scroll bar's value to 1
    public void setScrollto1(GameObject scrollBar)
    {
        if (scrollBar.GetComponent<Scrollbar>().value > 0.2)
        {
            scrollBar.GetComponent<Scrollbar>().value = 1;
            scrollBar.GetComponent<Scrollbar>().interactable = false;
        }
        
    }



}
