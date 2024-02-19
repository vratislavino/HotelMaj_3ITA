using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WaypointProvider : MonoBehaviour
{
    private static WaypointProvider instance;
    public static WaypointProvider Instance => instance;

    private List<Transform> waypoints;
    public IReadOnlyList<Transform> Waypoints => waypoints;

    private void Awake()
    {
        instance = this;        
    }

    // Start is called before the first frame update
    void Start()
    {
        waypoints = GetComponentsInChildren<Transform>().ToList();
        waypoints.RemoveAt(0); // odstranìní background
        waypoints.RemoveAt(0); // odstranìní spawnu
    }

    public Transform GetNextWaypoint(Transform currentWaypoint)
    {
        var index = waypoints.IndexOf(currentWaypoint);
        index++;
        return waypoints[index];
    }
}
