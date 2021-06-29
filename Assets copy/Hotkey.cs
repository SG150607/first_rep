using UnityEngine;
using UnityEngine.UI;


public class Hotkey : MonoBehaviour
{
    public Button button;
    public KeyCode key;

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            button.onClick.Invoke();
        }
    }
}
