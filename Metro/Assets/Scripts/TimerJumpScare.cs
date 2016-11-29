using UnityEngine;
using System.Collections;

public class TimerJumpScare : MonoBehaviour {
	public GameObject Scawy;
	private void Start()
	{
		StartCoroutine(ActivationRoutine());
	}

	private IEnumerator ActivationRoutine()
	{        
		//Wait for 14 secs.
		yield return new WaitForSeconds(16);

		//Turn My game object that is set to false(off) to True(on).
		Scawy.SetActive(true);

		//Turn the Game Oject back off after 1 sec.
		yield return new WaitForSeconds(0.4f);

		//Game object will turn off
		Scawy.SetActive(false);
	}
}
