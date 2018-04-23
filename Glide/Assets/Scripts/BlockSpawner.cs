﻿using UnityEngine;

public class BlockSpawner : MonoBehaviour {
    public GameObject[] shapes;

    public void SpawnShape()
    {
        int shapeIndex = Random.Range(0, 6);

        Instantiate(shapes[shapeIndex], transform.position, Quaternion.identity);
    }

	// Use this for initialization
	void Start () {
        SpawnShape();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
