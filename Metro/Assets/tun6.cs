using UnityEngine;
using System.Collections;

public class tun6 : MonoBehaviour {
	public GameObject audiotun6;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void OnTriggerEnter() {
		print ("hey!");
		audiotun6.SetActive(true);

	}

}