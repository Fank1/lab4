using UnityEngine;

public class WaypointGizmo : MonoBehaviour
{
    public float radius = 0.25f;
    public Color color = Color.green;

    private void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawSphere(transform.position, radius);
    }
}