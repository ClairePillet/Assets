using UnityEngine;
using System.Collections;

public class MoveHeroShot : MoveScript {
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.up*Time.deltaTime*speed);
	}
}
