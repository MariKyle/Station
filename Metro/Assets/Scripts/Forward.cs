using UnityEngine;
using System.Collections;

public class Forward : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//GetComponent<Rigidbody>().velocity = transform.forward;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.forward * Time.deltaTime * 25f;
	}
}
