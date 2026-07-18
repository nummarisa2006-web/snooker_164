using UnityEngine;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;
{ 
public class GameManager : MonoBehaviour
    private int playerScore;
    public int PlayerScore { get { return playerScore} }

public static GameManager instance;

    void Awake()
{
    indtance = this;
}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
