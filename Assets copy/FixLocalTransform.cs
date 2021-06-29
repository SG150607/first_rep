using UnityEngine;


public class FixLocalTransform : MonoBehaviour
{
    private Vector3 startLocalPosition;
    private Quaternion startRotation;
    void Start()
    {
        startLocalPosition = transform.localPosition;
        startRotation = transform.rotation;
    }

    void LateUpdate()
    {
        transform.rotation = startRotation;
        transform.position = transform.parent.position + startLocalPosition;
    }
}
