using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{

	private float sensitivity = 5.0f;

	public float smooth = 40.0f; // high number = low smooth = close to 0 (current position), low number = high smooth = close to 1 (next position)
	private PlayerController player;

	public void Start () 
	{

		player = GameObject.FindObjectOfType< PlayerController > ();

	}

	public void Update ( )
	{
		//transform.position = player.transform.position + Vector3.up * 2.5f; //attach camera to player's head 
		//transform.forward = player.transform.forward; // orient camera in direction of player

		//set vertical rotation based on mouse Y input 
		float angleX = -Input.GetAxisRaw ("Mouse Y") * sensitivity * Time.deltaTime;
		Vector3 newForward = Quaternion.AngleAxis (angleX, transform.right) * transform.forward;
		newForward = newForward.normalized;

		transform.forward = new Vector3 (player.transform.forward.x, newForward.y, player.transform.forward.z);

	}


}

// Update is called once per frame
//void Update () 
//{
//	RaycastHit hit;
//	if (Physics.Raycast (transform.position, transform.forward, out hit)) 
//	{
//		Debug.Log ("Raycast has hit");
//		//		if(hit.collider.CompareTag("Trigger"))
//		//		{
//		//			if(hit.collider.gameObject.GetComponent<Trigger>().IsVisual())
//		//				hit.collider.gameObject.GetComponent<Trigger>().GetTriggered();
//		//		}
//	}
//}
//	void OnTriggerEnter(Collider other)//for walking into walk on triggers
////	{
////		if (other.gameObject.GetComponent<Trigger> ())
////			other.gameObject.GetComponent<Trigger> ().GetTriggered ();
////	}

//// Update is called once per frame
//void Update () {
//	RaycastHit hit;
//	if (Physics.Raycast (transform.position, transform.forward, out hit)) {
//		if(hit.collider.CompareTag("Trigger"))
//		{
//			if(hit.collider.gameObject.GetComponent<Trigger>().IsVisual())
//				hit.collider.gameObject.GetComponent<Trigger>().GetTriggered();
//		}
//	}
//}
//void OnTriggerEnter(Collider other)//for walking into walk on triggers
//{
//	if (other.gameObject.GetComponent<Trigger> ())
//		other.gameObject.GetComponent<Trigger> ().GetTriggered ();
//}

//private float sensitivity = 10.0f;
//
//public float smooth = 40.0f; // high number = low smooth = close to 0 (current position), low number = high smooth = close to 1 (next position)
//private PlayerController player;
//
//public void Start () 
//{
//
//	player = GameObject.FindObjectOfType< PlayerController > ();
//
//}
//
//public void Update ( )
//{
//	transform.position = player.transform.position + Vector3.up * 2.5f; //attach camera to player's head 
//	//transform.forward = player.transform.forward; // orient camera in direction of player
//
//	//set vertical rotation based on mouse Y input 
//	float angleX = -Input.GetAxisRaw ("Mouse Y") * sensitivity * Time.deltaTime;
//	Vector3 newForward = Quaternion.AngleAxis (angleX, transform.right) * transform.forward;
//	newForward = newForward.normalized;
//
//	transform.forward = new Vector3 (player.transform.forward.x, newForward.y, player.transform.forward.z);
//
//}

