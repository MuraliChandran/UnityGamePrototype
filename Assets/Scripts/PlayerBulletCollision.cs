using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.name.Contains("Enemy(Clone"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            Singleton.instance.UpdateScore(1);
        }
    }
}
