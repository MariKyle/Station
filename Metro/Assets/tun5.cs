using UnityEngine;
using System.Collections;

public class tun5 : MonoBehaviour {
	public GameObject audiotun5;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void OnTriggerEnter() {
		print ("hey!");
		audiotun5.SetActive(true);

	}

}