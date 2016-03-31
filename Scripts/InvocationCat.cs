using UnityEngine;
using System.Collections;

public class InvocationCat : MonoBehaviour {

	private float timer;
	private int timer2;
	public GameObject cat;

	void Start(){
		InvokeRepeating ("instancierCat", 0, 1);
	}

	private void instancierCat(){
		GameObject catclone = (GameObject) Instantiate (cat, new Vector2 (Random.Range(-10,10), 6), new Quaternion (0, 0, 0, 0));
		catclone.transform.parent=transform;
		Destroy(catclone, 4);
	}
}
