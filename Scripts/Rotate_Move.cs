using UnityEngine;
using System.Collections;

public class Rotate_Move : MonoBehaviour {
	private GameObject target;
	public float speed;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		target=GameObject.Find("Patoune");
		float step = speed*Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.transform.position, step);
	}
}
