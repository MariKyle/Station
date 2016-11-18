using UnityEngine;
using System.Collections;

public class loadstat3 : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.F))
			Application.LoadLevel ("Station3");
	}
}