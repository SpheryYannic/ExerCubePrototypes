using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerData : MonoBehaviour
{

    public Vector3 previous;
    public Vector3 velocity;
    public float punchPower;

    public bool forward;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        velocity = (transform.position - previous) / Time.deltaTime;

        if (transform.position.z > previous.z)
        {
            forward = true;
        }
        else
        {
            forward = false;
        }

        previous = transform.position;
        punchPower = velocity.magnitude;
    }
}