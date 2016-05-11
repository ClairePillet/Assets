using UnityEngine;
using System.Collections;

public class MoveCatBase : MoveScript {
	
	// Use this for initialization
	public float x;
	public float y;
	// Update is called once per frame
	void Update () {
		deplacement(x,y);
	}

	private void deplacement(float x, float y){
		Vector2 direction = new Vector2(x,y);
		transform.Translate(direction*Time.deltaTime*speed);
	}
}
