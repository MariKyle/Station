using UnityEngine;
using System.Collections;

public class page2 : MonoBehaviour {
	public GameObject texts;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.T))
			texts.SetActive(true);
		if(Input.GetKey (KeyCode.Y))
			texts.SetActive (false);
	}
}
