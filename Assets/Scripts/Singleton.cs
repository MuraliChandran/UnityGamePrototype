using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Singleton : MonoBehaviour {

    public Canvas canvas;
    int total;
    // Use this for initialization
    public static Singleton instance = null;
    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);

        instance = this;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateScore(int score)
    {
        total += score;
        canvas.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = total.ToString();
    }
}
