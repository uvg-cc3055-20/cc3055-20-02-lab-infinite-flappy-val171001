using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour {

	public GameObject column;
	public float spawnTime = 4f;
	public float elapsedTime = 0f;

	// Use this for initialization
	void Start () {
		spawnTime = 1.25f;
		float random = Random.Range (-2f, 2f);
		Instantiate (column, new Vector3 (8, random, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.gameOver == false)
        {
            if (elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime;
            }
            else
            {
                float random = Random.Range(-2f, 2f);
                Instantiate(column, new Vector3(8, random, 0), Quaternion.identity);
                elapsedTime = 0;
            }

        }
	}
}
