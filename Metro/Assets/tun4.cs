using UnityEngine;
using System.Collections;

public class tun4 : MonoBehaviour {
	public GameObject audiotun4;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void OnTriggerEnter() {
		print ("hey!");
		audiotun4.SetActive(true);

	}

}