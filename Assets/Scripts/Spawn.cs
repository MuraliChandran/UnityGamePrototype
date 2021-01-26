using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject spawn;
    public GameObject cube;
  
	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnEnemy", 5f, 5f);
    }
	
	// Update is called once per frame
	void Update () {
       
	}

    void SpawnEnemy()
    {
        Instantiate(cube,spawn.transform.position, Quaternion.identity);
    }
}
