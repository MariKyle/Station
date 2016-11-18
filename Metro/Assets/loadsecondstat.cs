using UnityEngine;
using System.Collections;

public class loadsecondstat : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.F))
			Application.LoadLevel ("Station2");
	}
}