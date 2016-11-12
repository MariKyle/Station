using UnityEngine;
using System.Collections;

public class LoadBlah : MonoBehaviour {
		IEnumerator Start () {
			yield return new WaitForSeconds (15f);
			Application.LoadLevel ("Load");
		}
	}
