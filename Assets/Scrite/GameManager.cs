using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int playerScore;
    public int PlayerScore
    {
        get { return playerScore; }
        set { playerScore = value; }
    }

    [SerializeField]
    private GameObject[] ballPositions;

    [SerializeField]
    private GameObject ballPrefab;

    [SerializeField]
    private GameObject cueBall;

    [SerializeField]
    private GameObject ballLine;

    [SerializeField]
    private float xInput = 0f;

    [SerializeField]
    private GameManager cam;

    [SerializeField]
    private TMP_Text notiText;

    private static GameManager instance;
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        SetBall(BallColor.Red, 1);
        SetBall(BallColor.Yellow, 2);
        SetBall(BallColor.Green, 3);
        SetBall(BallColor.Brown, 4);
        SetBall(BallColor.Blue, 5);
        SetBall(BallColor.Pink, 6);
        SetBall(BallColor.Black, 7);
    }

    void Update()
    {
        RotateBall();

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            ShootBall();
        }

        if (Keyboard.current.rKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            xInput = -0.1f;
        }
        else if (Keyboard.current.lKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            xInput = 0.1f;
        }
        else
        {
            xInput = 0f;
        }

        if (Keyboard.current.backspaceKey.wasPressedThisFrame)
        {
            StopBall();
        }
    }

    private void SetBall(BallColor col, int position)
    {
        GameObject obj = Instantiate(ballPrefab, ballPositions[position].transform.position, Quaternion.identity);

            Ball b = obj.GetComponent<Ball>();
                b.SetColorAndPoint(col);
    }

    private void ShootBall()
    {
        Rigidbody rb = cueBall.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * 50, ForceMode.Impulse);
        ballLine.SetActive(false);

        cam.transform.parent = null;
        cam.transform.position = new Vector3(0f, 30f, -42f);
        cam.transform.eulerAngles = new Vector3(45f, 0f, 0f);
    }

    private void RotateBall()
    {
        if (cueBall != null)
        {
            cueBall.transform.Rotate(0f, xInput, 0f);
        }
    }

    private void StopBall()
    {
        Rigidbody rb = cueBall.GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        cueBall.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        ballLine.SetActive(true);
        CameraBehindCueBall();
    }

    private void CameraBehindCueBall()
    {
        cam.transform.parent = cueBall.transform;
        cam.transform.position = cueBall.transform.position + new Vector3(0f, 7f, -15f);
        cam.transform.eulerAngles = new Vector3(30f, 0f, 0f);
    }

    public void ShowNotiText(int n)
    {
        playerScore += n;
        notiText.text = $"This Ball:{n}\nTotal Score is {playerScore}";
    }
    public void ShowString(string s)
    {
      notiText.text = s;
    }
}
