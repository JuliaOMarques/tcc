using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temaJogoPort : MonoBehaviour {

    public Button btnPlay;
    public Text textTema;

    public GameObject infoTema;
    public Text textInfoTema;

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    public string[] nomeTema;
    public int numeroQuestoes;

    private int idTema;

    // Use this for initialization
    void Start()
    {
        idTema = 0;
        textTema.text = nomeTema[idTema];
        textInfoTema.text = "Você acertou x de x questões";
        infoTema.SetActive(false);
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);
        btnPlay.interactable = false;

    }

    public void selecioneTema(int i)
    {
        idTema = i;
        PlayerPrefs.SetInt("idTema", idTema);

        textTema.text = nomeTema[i];

        int notaFinal = PlayerPrefs.GetInt("notaFinalPort" + idTema.ToString());
        int acertos = PlayerPrefs.GetInt("acertos" + idTema.ToString());

        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        if (notaFinal == 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
        }
        else if (notaFinal >= 7)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (notaFinal >= 5)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }

        textInfoTema.text = "Você acertou " + acertos.ToString() + " de " + numeroQuestoes.ToString() + " questões";
        infoTema.SetActive(true);
        btnPlay.interactable = true;
    }

    public void jogar()
    {
        Application.LoadLevel("Port" + idTema.ToString());
    }
}
