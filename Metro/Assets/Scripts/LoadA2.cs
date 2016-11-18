using UnityEngine;
using System.Collections;

public class LoadA2 : MonoBehaviour {
	IEnumerator Start () {
		yield return new WaitForSeconds (15f);
		Application.LoadLevel ("LoadB");
	}
}