using System;
using UnityEngine;
using UnityEngine.Events;

public class Resource : MonoBehaviour
{
    public static Resource Find(string name)
    {
        foreach (var resource in FindObjectsOfType<Resource>())
        {
            if (resource.m_ResourceName == name)
                return resource;
        }
        Debug.LogError($"Не удалось найти ресурс {name}");
        return null;
    }

    [SerializeField] private string m_ResourceName = "gold";
    [SerializeField] private float m_Value = 0;
    [SerializeField] private float m_MaxValue = 9999;
    public float GetMaxValue() => m_MaxValue;
    public UnityEvent OnZero, OnMax;
    public event Action<float> ChangeEvent;

    public void Change(float change)
    {
        m_Value = Mathf.Clamp(m_Value + change, 0 , m_MaxValue);
        ChangeEvent?.Invoke(m_Value);
        if (m_Value == 0)
        {
            OnZero.Invoke();
        } else if (m_Value == m_MaxValue)
        {
            OnMax.Invoke();
        }
    }
}
