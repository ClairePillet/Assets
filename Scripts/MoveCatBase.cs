using UnityEngine;
using System.Collections;

public class MoveCatBase : MoveScript {
	
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.down*Time.deltaTime*speed);
	}
}
