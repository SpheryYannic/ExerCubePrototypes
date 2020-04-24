using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ProjectTrackerPositionOnWall : MonoBehaviour
{
    public LayerMask mask;

    public List<Transform> trackers = new List<Transform>();
    public List<BoxCollider> walls = new List<BoxCollider>();

    public GameObject wallRepresentation;
    public List<GameObject> objsOnWall;

    int amountOfTrackers;


    // Start is called before the first frame update
    void Start()
    {


        Screen.SetResolution(1920, 1080, true);

        for (int i = 0; i < trackers.Count; i++)
        {
            amountOfTrackers++;
        }

        Debug.Log(amountOfTrackers);

        //Create 3 wallreps for each wall per tracker
        for (int i = 0; i < amountOfTrackers; i++)
        {
            foreach (var item in walls)
            {
                objsOnWall.Add(Instantiate(wallRepresentation));
            }
        }

        Debug.Log("There are " + objsOnWall.Count + " wallReps in this List" );

        Debug.Log("Start worked");
    }


    // Update is called once per frame
    void Update()
    {

        int counter = 0;
        int trackerID = 0;

        for (int i = 0; i < objsOnWall.Count; i++)
        {
            if ( counter == 0 || counter == 3 || counter == 6 || counter == 9)
            {
                RaycastHit hit;

                if (Physics.Raycast(trackers[trackerID].position, Vector3.left, out hit, 20f, mask ))
                {
                    Debug.DrawRay(trackers[trackerID].position, Vector3.left * hit.distance, Color.red);
                    //Debug.Log("Did Hit");

                    objsOnWall[i].transform.position = hit.point;
                    Quaternion rot = Quaternion.Euler(new Vector3(0, 90, 0));
                    objsOnWall[i].transform.localRotation = hit.transform.rotation * rot;
                    objsOnWall[i].transform.localScale = CalcDis(hit.distance);

                }
            }
            else if (counter == 1 || counter == 4 || counter == 7 || counter == 10)
            {
                RaycastHit hit;

                if (Physics.Raycast(trackers[trackerID].position, Vector3.forward, out hit, 20f, mask))
                {
                    Debug.DrawRay(trackers[trackerID].position, Vector3.forward * hit.distance, Color.blue);
                    //Debug.Log("Did Hit");

                    objsOnWall[i].transform.position = hit.point;
                    Quaternion rot = Quaternion.Euler(new Vector3(0, 90, 0));
                    objsOnWall[i].transform.localRotation = hit.transform.rotation * rot;
                    objsOnWall[i].transform.localScale = CalcDis(hit.distance);

                }
            }
            else if (counter == 2 || counter == 5 || counter == 8 || counter == 11)
            {
                RaycastHit hit;

                if (Physics.Raycast(trackers[trackerID].position, Vector3.right, out hit, 20f, mask))
                {
                    Debug.DrawRay(trackers[trackerID].position, Vector3.right * hit.distance, Color.yellow);
                    //Debug.Log("Did Hit");

                    objsOnWall[i].transform.position = hit.point;
                    Quaternion rot = Quaternion.Euler(new Vector3(0, 90, 0));
                    objsOnWall[i].transform.localRotation = hit.transform.rotation * rot;
                    objsOnWall[i].transform.localScale = CalcDis(hit.distance);

                    trackerID++;
                }
            }

            counter++;


        }
    }

    Vector3 CalcDis(float dis)
    {
        float maxScale = 0.4f;

        float scale = 2.5f / dis / 15;

        if (scale > maxScale)
        {
            return new Vector3(maxScale, maxScale, maxScale) ;
        }
        else
        {
            return new Vector3(scale, scale, scale);
        }
    }
}
