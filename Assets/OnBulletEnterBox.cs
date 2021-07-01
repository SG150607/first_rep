using UnityEngine;
using UnityEngine.Events;

public class OnBulletEnterBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<BulletCollision>(out var _))
        {
            DataBank.get_bullet = Random.Range(3, 6);
            Destroy(gameObject);
        }
    }
}