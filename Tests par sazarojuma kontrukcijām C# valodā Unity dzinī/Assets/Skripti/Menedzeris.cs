using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menedzeris : MonoBehaviour
{

	public GameObject[] Limeni;
	public GameObject EkranaAties, Beigas;

	int currentLimenis;

	public void nepareizaAtbilde()
	{
		EkranaAties.SetActive(true);
	}

	public void SpelesAties()
	{
		Application.LoadLevel(Application.loadedLevel);
	}



	public void pareizaAtbilde()
	{
		if (currentLimenis + 1 != Limeni.Length) {
			Limeni[currentLimenis].SetActive(false);

			currentLimenis++;
			Limeni [currentLimenis].SetActive (true);
		}
		else
		{
			Beigas.SetActive(true);
			Limeni[currentLimenis].SetActive(false);
		}
	}



}
