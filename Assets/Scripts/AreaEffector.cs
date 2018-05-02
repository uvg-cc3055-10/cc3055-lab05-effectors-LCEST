using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {

    private float time=0;
    private bool prueba = false;
    public GameObject areaEffector;
	// Use this for initialization
	void Start () {
        prueba = false;
        time = 0;
	}

    // Update is called once per frame
    void Update() {
        time += Time.deltaTime;

        if(time>3){
            areaEffector.SetActive(prueba);
            time = 0;
            prueba = !prueba;
        }
    }
	
}
