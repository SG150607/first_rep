using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushLives : MonoBehaviour
{
    public int lives = 2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<BulletCollision>(out var _))
        {
            if (lives > 0)
            {
                lives -= 1;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
