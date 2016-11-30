using UnityEngine;
using System.Collections;

public class tigrtun1 : MonoBehaviour {
	public GameObject audiotun1;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void OnTriggerEnter() {
		print ("hey!");
		audiotun1.SetActive(true);

	}

}