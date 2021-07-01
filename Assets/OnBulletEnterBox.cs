using UnityEngine;


public class OnBulletEnterBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<BulletCollision>(out var _))
        {
            FindObjectOfType<PlayerFire>().bullets += DataBank.GetBullet();
            Destroy(gameObject);
        }
    }
}