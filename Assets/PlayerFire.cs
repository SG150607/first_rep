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
}