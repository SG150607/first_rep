using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform gunTransform;
    public int bullets;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (bullets > 0)
            {
                var bullet = Instantiate(bulletPrefab);
                bullet.transform.position = gunTransform.position;
                bullets -= 1;
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<OnBulletEnterBox>(out var _))
        {
            bullets += DataBank.get_bullet;
            DataBank.get_bullet = 0;
        }
    }
}