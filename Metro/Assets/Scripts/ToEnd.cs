using UnityEngine;
using System.Collections;

public class ToEnd : MonoBehaviour {
	IEnumerator Start () {
		yield return new WaitForSeconds (15f);
		Application.LoadLevel ("Station1");
	}
}