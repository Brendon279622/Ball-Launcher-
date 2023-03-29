using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

public class Enemy : MonoBehaviour
{

	public GameObject deathEffect;

	public float health = 4f;

	public static int EnemiesAlive = 0;

	void OnCollisionEnter2D(Collision2D colInfo)
	{
		if (colInfo.relativeVelocity.magnitude > health)
		{
			Die();
		}
	}

	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);

		Destroy(gameObject);
	}

}