using UnityEngine;

public class MoveWall : MonoBehaviour
{
    public float speed = 2f;              // Speed of movement
    public float distance = 3f;           // Max distance from start position
    public Vector3 direction = Vector3.right;  // Direction of movement

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Calculate oscillation using sine wave
        float offset = Mathf.Sin(Time.time * speed) * distance;
        transform.position = startPos + direction.normalized * offset;
    }
}
