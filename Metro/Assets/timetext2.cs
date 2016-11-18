﻿using UnityEngine;
using System.Collections;

public class timetext2 : MonoBehaviour {
	public GameObject texts;
	private void Start()
	{
		StartCoroutine(ActivationRoutine());
	}

	private IEnumerator ActivationRoutine()
	{        
		//Wait for 14 secs.
		yield return new WaitForSeconds(6);

		//Turn My game object that is set to false(off) to True(on).
		texts.SetActive(true);

		//Turn the Game Oject back off after 1 sec.
		yield return new WaitForSeconds(5);

		//Game object will turn off
		texts.SetActive(false);
	}
}
