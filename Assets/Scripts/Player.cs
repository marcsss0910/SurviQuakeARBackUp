using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public float currentHealth = 100f;
	public float maxHealth = 100f;

	void Start()
	{
		currentHealth = maxHealth;
	}


	public void TakeDamage(float damageAmt)
	{
		currentHealth -= damageAmt;
		if(currentHealth <= 0)
		{
			Debug.Log("DIE");
		}
	}

	private void OnCollisionEnter( Collision collision )
	{
		
		if (collision.gameObject.CompareTag("Debris"))
		{
			TakeDamage(20);
			Debug.Log("COLLIDE");
		}
	}
}
