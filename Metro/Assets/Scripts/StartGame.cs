using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	IEnumerator Start () {
		yield return new WaitForSeconds (30f);
		Application.LoadLevel ("Load");
	}
}