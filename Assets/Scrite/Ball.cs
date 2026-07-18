using System;
using UnityEngine;

public enum BallColor
{
    White,
    red,
    Yellow,
    Green,
    Brown,
    Blue,
    Pimk,
    Black,
}

public class Ball : MonoBehaviour
{
    [SerializeField]
    private int point;

    [Serializable] 
    private BallColor color;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
