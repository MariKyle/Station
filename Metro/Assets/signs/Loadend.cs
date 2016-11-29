using UnityEngine;
using System.Collections;

public class Loadend : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.F))
			Application.LoadLevel ("End");
	}
}