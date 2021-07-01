using UnityEngine;

public class RandomAppear : MonoBehaviour
{
    public GameObject prefab;
    public float enemi_counter;
    public float min_time;

    void Start()
    {
        for (int on_screen = 0; on_screen < enemi_counter; on_screen++)
        {
            Invoke("Spawn", Random.Range(min_time, min_time + 1));
            min_time += 1;
        }
    }
    public void Spawn()
    {
        var enemie = Instantiate(prefab);
        enemie.transform.position = new Vector2(-10, -4.2f);
    }
}
