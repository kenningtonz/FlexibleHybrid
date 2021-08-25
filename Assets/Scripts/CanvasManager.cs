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


    public void url()
    {
        Application.OpenURL("https://itsc.ontariotechu.ca/flexible-hybrid-learning/index.php");
    }
    public void kaltura(int numofscene)
    {
        switch (numofscene)
        {
            case 0:
                 SceneManager.LoadScene("Kaltura");
                break;
            case 1:
                SceneManager.LoadScene("Kaltura Settings");
                break;
            case 2:
                SceneManager.LoadScene("Kaltura Monitor");
                break;
            case 3:
                SceneManager.LoadScene("Kaltura Power");
                break;
            case 4:
                SceneManager.LoadScene("Kaltura Video");
                break;
            case 5:
                SceneManager.LoadScene("Kaltura Projector");
                break;
            case 6:
                SceneManager.LoadScene("Kaltura ClassView");
                break;

        }
       
    }

    public void intro()
    {
        SceneManager.LoadScene("Intro");
        
    }

    public void google(int numofscene)
    {
        switch (numofscene)
        {
            case 0:
                SceneManager.LoadScene("Google");
                break;
            case 1:
                SceneManager.LoadScene("GoogleMeet Settings");
                break;
            case 2:
                SceneManager.LoadScene("GoogleMeet Monitor");
                break;
            case 3:
                SceneManager.LoadScene("GoogleMeet Power");
                break;
            case 4:
                SceneManager.LoadScene("GoogleMeet Video");
                break;
            case 5:
                SceneManager.LoadScene("Google Projector");
                break;
            case 6:
                SceneManager.LoadScene("Google ClassView");
                break;

        }
    }

    public void zoom(int numofscene)
    {
        switch (numofscene)
        {
            case 0:
                SceneManager.LoadScene("Zoom");
                break;
            case 1:
                SceneManager.LoadScene("Zoom Settings");
                break;
            case 2:
                SceneManager.LoadScene("Zoom Monitor");
                break;
            case 3:
                SceneManager.LoadScene("Zoom Power");
                break;
            case 4:
                SceneManager.LoadScene("Zoom Video");
                break;
            case 5:
                SceneManager.LoadScene("Zoom Projector");
                break;
            case 6:
                SceneManager.LoadScene("Zoom ClassView");
                break;

        }
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void projector()
    {
        SceneManager.LoadScene("Projector");
    }

    public void classview()
    {
        SceneManager.LoadScene("ClassView");
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
