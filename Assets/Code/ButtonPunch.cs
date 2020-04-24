using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPunch : MonoBehaviour
{

    MenuManager menuManager;

    public LayerMask mask;
    public TrackerData tracker;

    AudioSource sfx;
    public GameObject HitEffect;

    // Start is called before the first frame update
    void Start()
    {
        menuManager = FindObjectOfType<MenuManager>();
        tracker = GetComponent<TrackerData>();
        sfx = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.forward, out hit, 20f, mask))
        {
            Debug.DrawRay(transform.position, Vector3.forward * hit.distance, Color.blue);

            
            if (tracker.punchPower > 2.5f && tracker.forward)
            {
                Debug.Log("Button activated");

                var button = hit.collider.GetComponent<ButtonTarget>();

                button.rb.useGravity = true;
                button.rb.AddForceAtPosition(Vector3.forward * 500, hit.point);
                button.coll.enabled = false;

                StartCoroutine(menuManager.Wait2SecToChangeState(button.targetState));
                Debug.Log("Called Enumerator");

                sfx.Play();
                Instantiate(HitEffect, hit.point, Quaternion.identity);




            }
            
        }
    }
}
