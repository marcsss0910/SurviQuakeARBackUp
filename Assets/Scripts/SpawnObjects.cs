
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
	public GameObject[] obstacles;
	public float secondSpawn = 0.1f;
	private bool isShaking = false;
	private bool isSpawning = false;
	public float spawnDuration = 20.0f;
	private bool start = false;

	void Update()
	{
		if(start && isShaking)
		{
			spawnDuration -= Time.deltaTime;
		}

		if (start && isShaking && isSpawning && spawnDuration >= 0)
		{
			isSpawning = true;
			StartCoroutine(ObjectSpawn());
			Debug.Log($"IS SPAWNINGGGG");

		}
	}

	public IEnumerator ObjectSpawn()
	{
		isSpawning = false;
		yield return new WaitForSeconds(secondSpawn);

		int randomInd = Random.Range(0, obstacles.Length);
		//Vector3 randomSpawnPos = new Vector3(Random.Range(-10, 30), 10, Random.Range(0, 2));
		Vector3 randomSpawnPos = new Vector3(Random.Range(-10, 30), 8);
		GameObject gameObject = Instantiate(obstacles[randomInd], randomSpawnPos, Quaternion.identity);

		Debug.Log(randomSpawnPos);
		Destroy(gameObject, 5f);
		isSpawning = true;

	}

	public void ClickStart()
	{
		start = true;
		StartSpawnShake();
	}

	public void StartSpawnShake()
	{
		
			isShaking = true;
			spawnDuration = 20.0f;
			isSpawning = true;
		
	}

	public void PauseSpawnShake()
	{
		isShaking = false;
		spawnDuration = 20.0f;
		isSpawning = false;
	}

	/*private void OnCollisionEnter( Collision collision )
	{
		Debug.Log("COLLIDE");

		if (collision.gameObject.TryGetComponent<Player>(out Player playerComponent))
		{
			playerComponent.TakeDamage(5);
		}
	}*/
}

