using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ComandosBasicos : MonoBehaviour {

	public void carregarCena(string nomeCena)
	{
		Application.LoadLevel(nomeCena);
	}
	public void resertarPontuacoes()
	{
		PlayerPrefs.DeleteAll();
	}


}