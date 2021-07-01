using UnityEngine;
using UnityEngine.Events;

public class OnBulletEnter : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<BulletCollision>(out var _))
        {
            Destroy(gameObject);
        }
    }
}