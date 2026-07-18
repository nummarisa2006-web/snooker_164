using UnityEngine;

public class test : MonoBehaviour
{
    private int n = 1;
    private float timer = 0f;
    void Awake()
    {
        Debug.Log("Awake");
    }

    void   Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        timer += Time.deltaTime;
    }
}
