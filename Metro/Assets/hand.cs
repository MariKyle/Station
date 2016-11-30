using UnityEngine;
using System.Collections;

public class hand : MonoBehaviour {
	public GameObject handag;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void OnTriggerEnter() {
		print ("hey!");
		handag.SetActive(true);

	}

}