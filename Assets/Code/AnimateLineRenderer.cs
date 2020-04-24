using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateLineRenderer : MonoBehaviour
{
    LineRenderer rend;
    public Color col;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<LineRenderer>();
        rend.material.SetColor("_EmissionColor", col);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var currOffset = rend.material.GetTextureOffset("_MainTex");
        rend.material.SetTextureOffset("_MainTex", new Vector2((currOffset.x + Time.deltaTime/10), currOffset.y));
    }
}
