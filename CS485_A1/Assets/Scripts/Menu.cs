using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Canvas Maincanvas;
    public Canvas Settingcanvas;
    //public Canvas Exitcanvas;

    void Awake()
    {
        Maincanvas.enabled = true;
        Settingcanvas.enabled = false;
        //Exitcanvas.enabled = true;
    }

    public void OptionOn()
    {
        Maincanvas.enabled = false;
        Settingcanvas.enabled = true;
        //Exitcanvas.enabled = false;
    }

    public void ReturnOn()
    {
        Maincanvas.enabled = true;
        Settingcanvas.enabled = true;
        //Exitcanvas.enabled = true;
    }

    public void LoadOn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(1);
    }

    /* 
    public void ExitOn()
	{
		Debug.Log("Has quit game");
		Application.Quit();
	}
    */
}