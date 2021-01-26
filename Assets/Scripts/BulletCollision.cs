using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

    public GameObject Player;
    Rigidbody rb;
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        
   }

    public void Move(GameObject Player)
    {
        rb = GetComponent<Rigidbody>();
        Vector3 aim = Player.transform.localPosition - transform.localPosition;
        rb.AddForce(aim * 1.0f, ForceMode.Impulse);
        Debug.Log("Bullet Collision");
    }
    private void FixedUpdate()
    {
        Destroy(transform.gameObject, 3.0f);
    }
    public void OnTriggerEnter(Collider other)
    {
        
        if(other.transform.name.Contains("Player"))
        {
            Debug.Log("Player Got Hit");
        }
    }
}
