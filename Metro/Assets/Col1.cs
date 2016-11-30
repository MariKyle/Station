using UnityEngine;
using System.Collections;

public class Col1 : MonoBehaviour {
	public GameObject audiotun2;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void OnTriggerEnter() {
		print ("hey!");
		audiotun2.SetActive(true);

	}

}