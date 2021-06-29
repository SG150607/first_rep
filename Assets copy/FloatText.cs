using UnityEngine;
using UnityEngine.UI;

public class FloatText : MonoBehaviour, IFloat
{
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }
    public void Use(float value)
    {
        text.text = ((int)value).ToString();
    }
}
