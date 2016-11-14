using UnityEngine;
using System.Collections;

public class loadsecondstat : MonoBehaviour {
	IEnumerator Start () {
		yield return new WaitForSeconds (15f);
		Application.LoadLevel ("station2");
	}
}
