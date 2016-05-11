using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;


/// <summary>
/// Handle hitpoints and damages
/// </summary>
public class HealthScript : MonoBehaviour
{
    /// <summary>
    /// Total hitpoints
    /// </summary>
    public int hp;
    //public AudioClip deathsound;
    //private AudioSource source;
    public AudioClip mort;

    /// <summary>
    /// Enemy or player?
    /// </summary>
    public bool isEnemy = true;

    /// <summary>
    /// Inflicts damage and check if the object should be destroyed
    /// </summary>
    /// <param name="damageCount"></param>
    public void Start(){
    	//AudioSource source=GetComponent<AudioSource>();
    }
    public void Damage(int damageCount)
    {
        hp -= damageCount;


        if (hp <= 0)
        {
            // Dead!
			AudioSource.PlayClipAtPoint(mort,transform.position, 1.0f);
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        // Is this a shot?
        bullet shot = otherCollider.gameObject.GetComponent<bullet>();
        if (shot != null)
        {
            // Avoid friendly fire
            if (shot.isEnemyShot != isEnemy)
            {
                Damage(shot.damage);

                // Destroy the shot
                Destroy(shot.gameObject); // Remember to always target the game object, otherwise you will just remove the script
            }
        }
    }
}