using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Vector2 speed = new Vector2 (50, 50);
	private Vector2 movement;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tir ();
	}

	void FixedUpdate() {
		Mouvement ();
	}

	void Mouvement() {
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");
		movement = new Vector2 (
			speed.x * inputX,
			speed.y * inputY);
		Rigidbody2D RB = GetComponent<Rigidbody2D>();
		RB.velocity=movement;
	}

	void tir(){
		bool shoot = Input.GetButtonDown("Fire1");
		shoot |= Input.GetButtonDown("Fire2");

		if (shoot==true)
		{
			Weapon weapon = GetComponent<Weapon>();
			if (weapon != null)
			{
				weapon.Attack(false);
			}
		}
	}
}


