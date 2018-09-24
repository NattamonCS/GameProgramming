using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
	public void QuitOptionOn()
	{
		Debug.Log("Has quit option menu");
		Application.Quit();
	}
}
