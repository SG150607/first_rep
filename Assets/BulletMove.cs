using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public Vector2 moveDirection = Vector2.right;

    private Rigidbody2D rig;

    public float direction;

    void Start()
    {
        if (direction < 0)
        {
            rig = GetComponent<Rigidbody2D>();
            rig.velocity = -moveDirection;
        }
        else
        {
            rig = GetComponent<Rigidbody2D>();
            rig.velocity = moveDirection;
        }
    }
}
