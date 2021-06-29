using UnityEngine;

public interface IFloat
{
    void Use(float f);
}

public class ListenResource : MonoBehaviour
{
    public string resourceName = "gold";
    private IFloat[] users;

    private void Start()
    {
        Resource.Find(resourceName).ChangeEvent += UseValue;
        users = GetComponentsInChildren<IFloat>();
    }
    private void UseValue(float value)
    {
        foreach (var user in users)
            user.Use(value);
    }
}
