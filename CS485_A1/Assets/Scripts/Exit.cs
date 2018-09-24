using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour 
{
	public void QuitOn()
	{
		Debug.Log("Has exit game");
		Application.Quit();
	}
}
