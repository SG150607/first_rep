using UnityEngine;

public class FloatBar : MonoBehaviour, IFloat
{
    private float m_Max, m_Width;
    public ListenResource m_Listener;
    void Start()
    {
        m_Max = Resource.Find(m_Listener.resourceName).GetMaxValue();
        m_Width = GetComponent<RectTransform>().rect.width;
    }

    public void Use(float value)
    {
        transform.localPosition = new Vector3(
            (value / m_Max - 1) * m_Width, 0, 0);
    }
}
