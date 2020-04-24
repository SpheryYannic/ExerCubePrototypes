using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTarget : MonoBehaviour
{

    public MenuState targetState;
    Vector3 startPos;
    Vector3 startRot;
    public Rigidbody rb;
    public Collider coll;

    // Start is called before the first frame update
    void Awake()
    {
        startPos = transform.position;
        startRot = transform.rotation.eulerAngles;
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();
    }

    private void Start()
    {

    }

    private void OnEnable()
    {

    }

    public void Reset()
    {

        Debug.Log("my pos is " + transform.position + " i should go to " + startPos);
        transform.position = startPos;
        transform.rotation = Quaternion.Euler(startRot);
        rb.useGravity = false;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        coll.enabled = true;
    }

}
