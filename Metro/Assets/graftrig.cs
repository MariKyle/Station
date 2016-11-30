using UnityEngine;
using System.Collections;

public class graftrig : MonoBehaviour {
	public GameObject audio;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void OnTriggerEnter() {
		print ("hey!");
		audio.SetActive(true);

	}

}