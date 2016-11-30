using UnityEngine;
using System.Collections;

public class remybye : MonoBehaviour {
	public GameObject rem;
	public GameObject audiyou;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void OnTriggerEnter() {
		print ("hey!");
		rem.SetActive(false);
		audiyou.SetActive (true);

	}

}