using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public int lives = 1;
    public GameObject gameOverText;
    public GameObject WinText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<ImZombie>(out var _))
        {
            lives -= 1;
            //myAnimator.SetBool("Death");
            gameOverText.SetActive(true);
            //gameObject.SetActive(false);
        }
    }

    private void Win()
    {
        WinText.SetActive(true);
        gameObject.SetActive(false);
    }
}
