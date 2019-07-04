using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModoJogo : MonoBehaviour
{

    public Button btnPlay;
    public Text textModo;
    
    public GameObject infoModo;
    public Text textInfoModo;
    
    public string[] nomeModo;

    private int idModo;

    // Use this for initialization
    void Iniciar()
    {
        idModo = 0;
        textModo.text = nomeModo[idModo];

    }
    public void selecionarModo(int i)
    {
        idModo = i;
        PlayerPrefs.SetInt("idModo", idModo);

        textModo.text = nomeModo[i];
    }

    public void modo()
    {
        Application.LoadLevel("Modo"+ idModo.ToString());
    }

}