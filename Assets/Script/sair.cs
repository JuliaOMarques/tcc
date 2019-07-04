using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sair : MonoBehaviour {

	public void quit(){
		Debug.Log("Você saiu do jogo");
		Application.Quit();
	}
}
