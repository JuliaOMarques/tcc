using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarBotao : MonoBehaviour {
	public AudioSource audio;
	private int intaudio = 1;
	public GameObject ButtonSomOn;
	public GameObject ButtonSomOff;

	// Use this for inicialization
	void Start () {
		audio.mute = true;
		ButtonSomOff.SetActive(false);
		if(intaudio == 1) 
		{
			audio.mute = false;
		}
		else if(intaudio == 0)
		{
			audio.mute = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void deixarmudo(){
		audio.mute = true;
		ButtonSomOn.SetActive(false);
		ButtonSomOff.SetActive(true);
	}

	public void tocarsom(){
		audio.mute = false;
		ButtonSomOff.SetActive(false);
		ButtonSomOn.SetActive(true);
	}


	}
