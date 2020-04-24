using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

#if !(UNITY_EDITOR)

                Debug.Log("displays connected: " + Display.displays.Length);
        // Display.displays[0] is the primary, default display and is always ON.
        // Check if additional displays are available and activate each.
        if (Display.displays.Length > 1)
            Display.displays[1].Activate();

        Display.displays[1].SetRenderingResolution(1080, 1080);

        if (Display.displays.Length > 2)
            Display.displays[2].Activate();

        Display.displays[2].SetRenderingResolution(1080, 1080);

        if (Display.displays.Length > 3)
            Display.displays[3].Activate();

        Display.displays[3].SetRenderingResolution(1080, 1080);

        if (Display.displays.Length > 4)
            Display.displays[4].Activate();

        Display.displays[4].SetRenderingResolution(1080, 1080);

#endif

    }

    // Update is called once per frame
    void Update()
    {

    }
}
