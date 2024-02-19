using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    protected Transform currentWaypoint;

    [SerializeField] protected float speed;

    // Start is called before the first frame update
    void Start()
    {
        currentWaypoint = WaypointProvider.Instance.Waypoints.First();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(currentWaypoint);
        transform.Translate(-transform.right * speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, currentWaypoint.position) < 0.1f)
        {
            currentWaypoint = WaypointProvider.Instance.GetNextWaypoint(currentWaypoint);
        }
    }
}
