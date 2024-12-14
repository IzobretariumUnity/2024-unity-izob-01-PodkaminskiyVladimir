using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform point;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = point.transform.position;
    }
}