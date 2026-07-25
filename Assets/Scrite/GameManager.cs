using UnityEngine;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;
{ 
public class GameManager : MonoBehaviour
    private int playerScore;
    public int PlayerScore { get { return playerScore} }

public static GameManager instance;

[SerializeField]
private GameObject[] ballPositions;

[SerializeField]
private GameObject[] ballPrefab;



void Awake()
{
    indtance = this;
}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       SetBall(BallColor.red, 1)
        SetBall(BallColor.yellow, 2)
        SetBall(BallColor.green, 3)
        SetBall(BallColor.brown, 4)
        SetBall(BallColor.blue, 5)
        SetBall(BallColor.black, 6)


    }

    // Update is called once per frame
    void Update()
    {
        
    }

private void SetBall(BallColor col, int i)
{
    GameObject obj = Instantiate(ballPrefab, ballPositions[i].transform.position, Quaternion.identity);

    Ball b = obj.GetComponent<Ball>();
    b.SetColorAndPoint(col);
}


}
