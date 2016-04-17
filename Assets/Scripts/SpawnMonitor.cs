using UnityEngine;
using System.Collections;

public class SpawnMonitor : MonoBehaviour {

	public int maxPlatforms = 5;
	public GameObject platform;
	public GameObject winningPlatform;
	public float horizontalMin = 6.5f;
	public float horizontalMax = 14f;
	public float verticalMin = -6f;
	public float verticalMax = 6f;

	private Vector2 originPos;

	// Use this for initialization
	void Start () {
		Spawn ();
	}

	public void Spawn(){
		originPos = transform.position;
		for (int i = 0; i < maxPlatforms; i++) {
			Vector2 randomPos = originPos + new Vector2 (Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMax, verticalMin));
			Instantiate (platform, randomPos, Quaternion.identity);
			originPos = randomPos;
		}
		Vector2 newRand = originPos + new Vector2 (Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMax, verticalMin));
		Instantiate(winningPlatform, newRand, Quaternion.identity);
		originPos = newRand;
	}
}
