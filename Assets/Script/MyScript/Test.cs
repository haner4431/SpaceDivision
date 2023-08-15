using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public new Collider collider;
    public new Renderer renderer;
    private Bounds bounds;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        collider = GetComponent<Collider>();
        bounds = collider.bounds;
    }

    private void OnDrawGizmos()
    {
        bounds = renderer.bounds;
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(bounds.center, 0.1f);

        Gizmos.color = Color.green;
        Gizmos.DrawSphere(bounds.max, 0.1f);

        Gizmos.color = Color.red;
        Gizmos.DrawSphere(bounds.min, 0.1f);

        Gizmos.color = Color.black;
        Gizmos.DrawLine(bounds.center ,bounds.center+bounds.size);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(bounds.center , bounds.center+bounds.extents);

        Gizmos.color = Color.grey;
        Gizmos.DrawCube(bounds.center + new Vector3(3,0,0),bounds.size);

    }
}
