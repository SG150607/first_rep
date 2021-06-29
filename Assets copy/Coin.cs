using UnityEngine;

public class Coin : MonoBehaviour
{
    public float value = 1;
    public string resourceName = "gold";
    public void Collect()
    {
        Resource.Find(resourceName).Change(value);
        Destroy(gameObject);
    }
}