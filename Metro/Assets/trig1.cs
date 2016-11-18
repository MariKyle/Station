using UnityEngine;
using System.Collections;

public class trig1 : MonoBehaviour {
	public GameObject texts;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

		void OnTriggerEnter() {
		print ("hey!");
			texts.SetActive(true);

		}

}
