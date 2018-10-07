using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PonyMove : MonoBehaviour {

    // The target marker.
    public Transform target;

    // Speed in units per sec.
    public float speed;

    void Start()
    {
      
    }

    void Update()
    {
        speed = 10;
        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        //target.position = GameObject.Find("Camera").transform.position;
       transform.LookAt(transform.position - (GameObject.Find("Camera").transform.position - transform.position));
        //transform.rotation = Quaternion.LookRotation(transform.position - target.transform.position);
        
        // Move our position a step closer to the target.
        transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Camera").transform.position, step);
    }
}
