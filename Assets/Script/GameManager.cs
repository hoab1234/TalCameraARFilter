using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public GameObject origin;
  




    public void GoMainMenu_1()
    {
        SceneManager.LoadScene("MainMenu_1");
        
    }

    public void StartTal()
    {
        SceneManager.LoadScene("Mask_1");
        
    }

    public void EndTal()
    {
        Application.Quit();
    }

    public void TalExplain()
    {
        SceneManager.LoadScene("TalExplain");
       
    }

    public void Yangban()
    {
        SceneManager.LoadScene("Yangban");
        
    }

    public void Gaksi()
    {
        SceneManager.LoadScene("Gaksi");
        
    }

    public void Imme()
    {
        SceneManager.LoadScene("Imme");
        
    }

    public void bunae()
    {
        SceneManager.LoadScene("Bunae");
       
    }

    public void BMainMenu_1()
    {
        SceneManager.LoadScene("MainMenu_1");
        
    }

    public void BMask_1()
    {
        SceneManager.LoadScene("Mask_1");
       
    }

    public void Origin_open()
    {
        origin.SetActive(true);
    }

    public void Origin_close()
    {
        origin.SetActive(false);
    }


}
