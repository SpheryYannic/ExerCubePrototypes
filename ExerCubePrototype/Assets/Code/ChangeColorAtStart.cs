using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorAtStart : MonoBehaviour
{

    public Color col;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = col;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
