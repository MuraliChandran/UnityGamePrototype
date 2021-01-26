using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject Player;
    public GameObject Bullet;
    float x = 0;
    int waitingtime = 2;
    float timer = 0;
    float movespeed;
    Rigidbody rb;
    float dirx, dirz;
    
    // Use this for initialization
    void Start () {
        movespeed = 3f;
        rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        dirx = -Input.GetAxis("Horizontal") * movespeed;
        dirz = -Input.GetAxis("Vertical") * movespeed;
       
        
        if(Input.GetKey(KeyCode.Mouse0))
        {
            if (timer > waitingtime)
            {
                Instantiate(Bullet, transform.position, transform.rotation);
                timer = 0;
            }
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirx, rb.velocity.y, dirz);
    }
}
