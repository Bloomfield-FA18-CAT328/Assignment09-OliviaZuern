using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathScript : MonoBehaviour {
    public List<Vector3> Points;


    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1f, 0f, 0f);
        foreach (Vector3 vector in Points)
        {
            Gizmos.DrawSphere(vector, 0.1f);
        }
        Gizmos.DrawLine(Points[0], Points[1]);
        Gizmos.DrawLine(Points[1], Points[2]);
        Gizmos.DrawLine(Points[2], Points[3]);
        Gizmos.DrawLine(Points[3], Points[4]);
        Gizmos.DrawLine(Points[4], Points[0]);


    }
}
