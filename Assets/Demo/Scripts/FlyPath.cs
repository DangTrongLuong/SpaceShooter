using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public WayPoint[] waypoints;

    private void Reset() => waypoints = GetComponentsInChildren<WayPoint>();
}
