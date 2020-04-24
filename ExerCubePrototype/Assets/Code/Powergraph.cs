using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powergraph : MonoBehaviour
{

    public TrackerData tracker;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x, tracker.punchPower, transform.localScale.z);
    }
}
