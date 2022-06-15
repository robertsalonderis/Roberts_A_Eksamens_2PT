using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour {
	public List<JautajumiUnAtbildes> JuA;
	public GameObject[] opcijas;
	public int currentJautajums;

	public Text JautajumiTxt;


	private void Start()
	{
		generateJautajumus();
	}

	public void Pareizi()
	{
		
	}

	void SetAtbildes()
	{
		for (int i = 0; i < opcijas.Length; i++) {
			opcijas [i].GetComponent<Atbildes> ().irPareizs = false;
			opcijas [i].transform.GetChild (0).GetComponent<Text> ().text = JuA [currentJautajums].Atbildes[i];

			if (JuA [currentJautajums].PareizasAtbildes == i + 1) {
				options[i].GetComponent<Atbildes> ().irPareizs = true;
			}
		}
	}

	void generateJautajumus()
	{
		currentJautajums = Random.Range (0, JuA.Count);

		JautajumiTxt.text = JuA [currentJautajums].Jautajumi;
		SetAtbildes();

		JuA.RemoveAt (currentJautajums);

	}
}
