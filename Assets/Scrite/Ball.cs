using System;
using UnityEngine;
using UnityEngine.EventSystems;

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

public class Ball : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private int point;

    [SerializeField] 
    private BallColor color;

    [SerializeField]
    private MeshRenderer rd;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(point);
        GameManager.Instance.PlayerScore += point;
        Destroy(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetColorAndPoint(BallColor color)
    {
        switch (color)
        {
            case BallColor.White:
                point = 0;
                rd.material.color = Color.white;
                break;
            case BallColor.Red:
                point = 1;
                rd.material.color = Color.red;
                break;
            case BallColor.Yellow:
                point = 2;
                rd.material.color = Color.yellow;
                break;
            case BallColor.Green:
                point = 3;
                rd.material.color = Color.green;
                break;
            case BallColor.Brown:
                point = 4;
                rd.material.color = Color.brown;
                break;
            case BallColor.Blue:
                point = 5;
                rd.material.color = Color.blue;
                break;
            case BallColor.Pink:
                point = 6;
                rd.material.color = Color.pink;
                break;
            case BallColor.Black:
                point = 7;
                rd.material.color = Color.black;
                break;
        } 
            
    }    
}
