using UnityEngine;
using System.Collections;

public class tun3 : MonoBehaviour {
	public GameObject audiotun3;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void OnTriggerEnter() {
		print ("hey!");
		audiotun3.SetActive(true);

	}

}