using Unity.VisualScripting;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Ball b = other.GetComponent<Ball>();

            if (b != null)
            {
                if (b.Point > 0)
                {
                    GameManager.Instance.ShowString("White Ball drop!!!\nYou Lose!");
                    Time.timeScale = 0f;
                }
                else
                {
                    GameManager.Instance.PlayerScore += b.Point;
                }
                Destroy(b.gameObject);
            }
        }
    }
}
