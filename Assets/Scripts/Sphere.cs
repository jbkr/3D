using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Transform pivot;          // The "tilted world" GameObject
    public float orbitSpeed = 20f;   // Degrees per second
    public float radius = 5f;

    private float angle;

    void Update()
    {
        if (pivot == null) return;

        angle += orbitSpeed * Time.deltaTime;

        // Compute orbit position in pivot's local space
        Vector3 localPosition = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad) * radius, 0f, Mathf.Sin(angle * Mathf.Deg2Rad) * radius);

        // Transform local orbit position to world space
        transform.position = pivot.TransformPoint(localPosition);
    }

}
