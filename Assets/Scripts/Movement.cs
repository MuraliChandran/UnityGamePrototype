using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public GameObject bullet;
    public float EnemyVelocity;
    public float xmax;
    public float xmin;
    public float zmax;
    public float zmin;

    float x = 0.1f;
    float z = 0.1f;
    float angle = 180f;

    Vector3 aim;
    float changetime = 3f;
    float time, timer;
    float watingTime = 2f;
    RaycastHit hit;
	// Use this for initialization
	void Start () {

        x = Random.Range(-EnemyVelocity, EnemyVelocity);
        z = Random.Range(-EnemyVelocity, EnemyVelocity);
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        timer += Time.deltaTime;
        if (Physics.Raycast(transform.localPosition, transform.forward, out hit, 30))
        {
            
            if(hit.transform.name.Contains("Player"))
            {
                Debug.DrawLine(transform.localPosition, hit.transform.localPosition, Color.red);
                if (timer > watingTime)
                {
                    var GameObject = Instantiate(bullet, transform.localPosition, Quaternion.identity);
                    GameObject.GetComponent<BulletCollision>().Move(hit.transform.gameObject);
                    timer = 0;
                }

            }
        }

        if (Physics.Raycast(transform.localPosition, -transform.forward, out hit, 30))
        {

            if (hit.transform.name.Contains("Player"))
            {
                Debug.DrawLine(transform.localPosition, hit.transform.localPosition, Color.green);
                if (timer > watingTime)
                {
                    var GameObject = Instantiate(bullet, transform.localPosition, Quaternion.identity);
                    GameObject.GetComponent<BulletCollision>().Move(hit.transform.gameObject);
                    timer = 0;
                }
            }
        }


        if (Physics.Raycast(transform.localPosition, transform.right, out hit, 30))
        {

            if (hit.transform.name.Contains("Player"))
            {
                Debug.DrawLine(transform.localPosition, hit.transform.localPosition, Color.blue);
                if (timer > watingTime)
                {
                    var GameObject = Instantiate(bullet, transform.localPosition, Quaternion.identity);
                    GameObject.GetComponent<BulletCollision>().Move(hit.transform.gameObject);
                    timer = 0;
                }
            }
        }

        if (Physics.Raycast(transform.localPosition, -transform.right, out hit, 30))
        {

            if (hit.transform.name.Contains("Player"))
            {
                Debug.DrawLine(transform.localPosition, hit.transform.localPosition, Color.grey);
                if (timer > watingTime)
                {
                    var GameObject = Instantiate(bullet, transform.localPosition, Quaternion.identity);
                    GameObject.GetComponent<BulletCollision>().Move(hit.transform.gameObject);
                    timer = 0;
                }
            }
        }


        if (transform.localPosition.x > xmax)
        {
            x = Random.Range(-EnemyVelocity, 0);
            transform.localRotation = Quaternion.Euler(0, angle, 0);
            time = 0.0f;
        }

        if (transform.localPosition.x < xmin)
        {
            x = Random.Range(0, EnemyVelocity);
            transform.localRotation = Quaternion.Euler(0, angle, 0);
            time = 0.0f;
        }

        if (transform.localPosition.z > zmax)
        {
            z = Random.Range(-EnemyVelocity, 0);
            transform.localRotation = Quaternion.Euler(0, angle, 0);
            time = 0.0f;
        }

        if (transform.localPosition.z < zmin)
        {
            z = Random.Range(0, EnemyVelocity);
            transform.localRotation = Quaternion.Euler(0, angle, 0);
            time = 0.0f;
        }
   

        if(time > changetime)
        {
            x = Random.Range(-EnemyVelocity, EnemyVelocity);
            z = Random.Range(-EnemyVelocity, EnemyVelocity);
            transform.localRotation = Quaternion.Euler(0, angle, 0);
            time = 0.0f;
        }

        transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y, transform.localPosition.z + z);
    }

   
}
