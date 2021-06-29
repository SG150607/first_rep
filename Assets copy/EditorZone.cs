using UnityEngine;

public class EditorZone : MonoBehaviour
{
    private void Awake()
    {
        if (!Application.isEditor)
        {
            Destroy(this);
        }
    }

    [SerializeField] private Mesh coinMesh;
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireMesh(coinMesh, transform.position, Quaternion.identity, Vector3.one * 3);
    }
}
