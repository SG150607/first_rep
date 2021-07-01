using UnityEngine;

public class LinearMove : MonoBehaviour
{
    public Vector2 moveDirection = Vector2.right;

    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = moveDirection;
    }
}