using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atbildes : MonoBehaviour {

	public bool irPareizs = false;
	public QuizManager quizManager;

	public void Atbilde()
	{
		if(irPareizs)
		{
			Debug.Log("Pareiza atbilde");
			quizManager.Pareizi();
		}
		else
		{
			Debug.Log("Nepareiza Abilde");
			quizManager.Pareizi();
		}	
	}
}
