using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject MultiPalyer;
    public GameObject Career;

   public void mainmenu()
    {
        MainMenu.SetActive(true);
        MultiPalyer.SetActive(false);
        Career.SetActive(false);
    }
    public void multiplayer()
    {
        MainMenu.SetActive(false);
        MultiPalyer.SetActive(true);
        Career.SetActive(false);
    }
    public void carrer()
    {
        MainMenu.SetActive(false);
        MultiPalyer.SetActive(false);
        Career.SetActive(true);
    }


    public void Game()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Quit()
    {
        Application.Quit();
    }
}

