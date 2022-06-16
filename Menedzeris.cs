using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menedzeris : MonoBehaviour
{

	public GameObject[] Limeni;//masīvs līmeņiem
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
		if (currentLimenis + 1 != Limeni.Length) {//If pārbauda vai neatrodas pēdejā līmenī
			Limeni[currentLimenis].SetActive(false);//Aktivizē pašreizējo līmeni

			currentLimenis++;//atjaunina pašreizējā līmeņa vērtību par 1
			Limeni [currentLimenis].SetActive (true);//Aktivizē nākošo līmeni
		}
		else
		{
			Beigas.SetActive(true);
			Limeni[currentLimenis].SetActive(false);
		}
	}



}
