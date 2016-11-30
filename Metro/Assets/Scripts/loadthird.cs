using UnityEngine;
using System.Collections;

public class loadthird : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.F))
			Application.LoadLevel ("EndGame");
	}
}