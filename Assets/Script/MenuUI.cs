using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{

    public GameObject homeAexit;

    public Button Back;
    public Button Yangban;
    public Button Gaksi;
    public Button Imme;
    public Button bunae;
    // Start is called before the first frame update
    public void Menu()
    {
        Time.timeScale = 0;
        homeAexit.SetActive(true);
        
    }

    public void home()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu_1");
    }

    public void exit()
    {
        Time.timeScale = 1;
        Application.Quit();
    }

    public void menuexit()
    {
        Time.timeScale = 1;
        homeAexit.SetActive(false);
   
    }
}

/*
Yangban.interactable = false;
Gaksi.interactable = false;
Imme.interactable = false;
bunae.interactable = false;
Back.interactable = false;


Yangban.interactable = true;
Gaksi.interactable = true;
Imme.interactable = true;
bunae.interactable = true;
Back.interactable = true;*/