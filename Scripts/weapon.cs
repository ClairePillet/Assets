using UnityEngine;

/// <summary>
/// Launch projectile
/// </summary>
public class weapon : MonoBehaviour
{
    //--------------------------------
    // 1 - Designer variables
    //--------------------------------

    /// <summary>
    /// Projectile prefab for shooting
    /// </summary>
    public GameObject shotPrefab;

    /// <summary>
    /// Cooldown in seconds between two shots
    /// </summary>
    public float shootingRate;

    //--------------------------------
    // 2 - Cooldown
    //--------------------------------

    protected float shootCooldown;
    //--------------------------------
    // 3 - Shooting from another script
    //--------------------------------

    /// <summary>
    /// Create a new projectile if possible
    /// </summary>
    public void Attack ()
	{
        
		if (CanAttack) {
			shootCooldown = shootingRate;

			// Create a new shot
			Instantiate (shotPrefab, transform.position,new Quaternion (0, 0, 0, 0));
		}
        
    }

    /// <summary>
    /// Is the weapon ready to create a new projectile?
    /// </summary>
    public bool CanAttack
    {
        get
        {
            return shootCooldown <= 0f;
        }
    }
}
