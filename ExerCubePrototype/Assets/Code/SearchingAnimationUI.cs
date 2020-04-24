using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchingAnimationUI : MonoBehaviour
{

    Image img;
    public float speed;
    bool up = true;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

        

        if (up)
        {
            img.fillAmount += Time.deltaTime * speed;

            if(img.fillAmount == 1)
            {
                img.fillClockwise = !img.fillClockwise;
                up = !up;
            }

        }
        else
        {
            img.fillAmount -= Time.deltaTime * speed;

            if (img.fillAmount == 0)
            {
                img.fillClockwise = !img.fillClockwise;
                up = !up;
            }
        }

    }
}
