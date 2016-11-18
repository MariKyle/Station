using UnityEngine;
using System.Collections;

public class Turn : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		var speed = 1;
		if (Input.GetKey(KeyCode.F))
			transform.Rotate(Vector3.right * speed * Time.deltaTime);

		if (Input.GetKey(KeyCode.G))
			transform.Rotate(-Vector3.right * speed * Time.deltaTime);
	}
}
