using UnityEngine;
using System.Collections;

public class timeron : MonoBehaviour {
	public GameObject LightBulb;
	private void Start()
	{
		StartCoroutine(ActivationRoutine());
	}

	private IEnumerator ActivationRoutine()
	{        
		//Wait for 14 secs.
		yield return new WaitForSeconds(3);

		//Turn My game object that is set to false(off) to True(on).
		LightBulb.SetActive(true);

		//Turn the Game Oject back off after 1 sec.
		//yield return new WaitForSeconds(2);

		//Game object will turn off
		//LightBulb.SetActive(true);
	}
}
