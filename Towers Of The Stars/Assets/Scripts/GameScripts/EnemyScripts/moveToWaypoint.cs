using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToWaypoint : MonoBehaviour
{
    public WaypointScript waypointScript;
    public int currentIndex;
    public float speed;

    void Start()
    {
        waypointScript = GameObject.Find("WaypointHolder").GetComponent<WaypointScript>();
        speed = GetComponent<EnemyStats>().speed;
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 WaypointVector = waypointScript.Waypoints[currentIndex].position - transform.position;

        if(WaypointVector.magnitude <= 0.05)
        {
            currentIndex++;
        }

        //Direction 
        WaypointVector.Normalize();
        transform.position += WaypointVector * Time.deltaTime * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("LastWaypoint"))
        {
            Destroy(gameObject);
        }
        
    }
}
