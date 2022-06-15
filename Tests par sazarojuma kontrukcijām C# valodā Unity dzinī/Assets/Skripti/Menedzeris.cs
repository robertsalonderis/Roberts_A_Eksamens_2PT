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
}
