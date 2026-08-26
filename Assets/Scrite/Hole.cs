using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Ball b = other.GetComponent<Ball>();

        if (b != null)
        {
            if (b.Point == 0)
            {
                GameManager.Instance.ShowNotiText("Game Over!\nYour white ball has dropped!");
                Time.timeScale = 0;
            }
            else
            {
                GameManager.Instance.ShowNotiText(b.Point);
            }
            Destroy(b.gameObject);
        }
    }
}

