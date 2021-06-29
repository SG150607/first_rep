using UnityEngine;

public class ResourceDrain : MonoBehaviour
{
    public string m_ResourceName = "playerWater";
    public float m_DrainSpeed = 1;

    private Resource m_Resource;
    private void Start()
    {
        m_Resource = Resource.Find(m_ResourceName);
    }

    void Update()
    {
        m_Resource.Change(-m_DrainSpeed * Time.deltaTime);
    }
}
