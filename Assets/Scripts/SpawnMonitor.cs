﻿using UnityEngine;
using System.Collections;

public class SpawnMonitor : MonoBehaviour {

	public int maxPlatforms = 20;
	public GameObject platform;
	public float horizontalMin = 6.5f;
	public float horizontalMax = 14f;
	public float verticalMin = -6f;
	public float verticalMax = 6f;

	private Vector2 originPos;

	// Use this for initialization
	void Start () {
		originPos = transform.position;
		Spawn ();
	}

	void Spawn(){
		for (int i = 0; i < maxPlatforms; i++) {
			Vector2 randomPos = originPos + new Vector2 (Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMax, verticalMin));
			Instantiate (platform, randomPos, Quaternion.identity);
			originPos = randomPos;
		}
	}
}
