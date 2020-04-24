using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenTouched : MonoBehaviour
{
    public float minDistance;
    BoxCollider coll;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<BoxCollider>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Tracker") && other.transform.localScale.x > coll.transform.localScale.x)
        {
            var dis = Vector3.Distance(other.transform.position, transform.position);

            if (dis < minDistance)
            {
                Debug.Log("Entered");
                Destroy(gameObject);
            }
        }
    }
}
