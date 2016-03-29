using UnityEngine;
using System.Collections;

public class CatBaseWeapon : weapon {

	// Use this for initialization
	void Start()
    {
        shootCooldown = 0f;
       
    }
	
	// Update is called once per frame
	void Update () {
		if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;

        }
		Attack();
	}
}
