using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour {

    public LineRenderer line;
    public DistanceJoint2D distanceJoint;
    // Use this for initialization

    void Start () {
        distanceJoint = GetComponent<DistanceJoint2D>();
        line = GetComponent<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        //Codigo para hacer que el personaje se vea afectado por el peso de las particulas
        line.SetPosition(0, transform.position);
        line.SetPosition(1,
        distanceJoint.connectedBody.transform.position);
    }
}
