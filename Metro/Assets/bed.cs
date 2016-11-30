using UnityEngine;
using System.Collections;

public class bed : MonoBehaviour {
	public GameObject bedta;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void OnTriggerEnter() {
		print ("hey!");
		bedta.SetActive(true);

	}

}