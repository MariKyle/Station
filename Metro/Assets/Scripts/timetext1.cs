using UnityEngine;
using System.Collections;

public class timetext1 : MonoBehaviour {
	public GameObject texts;
	private void Start()
	{
		StartCoroutine(ActivationRoutine());
	}

	private IEnumerator ActivationRoutine()
	{        
		//Wait for 14 secs.
		yield return new WaitForSeconds(5);

		//Turn My game object that is set to false(off) to True(on).
		texts.SetActive(false);

		//Turn the Game Oject back off after 1 sec.
		//yield return new WaitForSeconds(2);

		//Game object will turn off
		//LightBulb.SetActive(true);
	}
}
