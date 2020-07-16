using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPawn : Pawn
{
    public List<Transform> Waypoints;
    public int currentWaypoint;
}
