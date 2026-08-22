using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource[] bgm;
    private AudioSource[] BGM { get { return bgm; } set { bgm = value; } }

    [SerializeField]
    private AudioSource[] sfx;
    public AudioSource[] SFX { get { return sfx; } set { sfx = value; } }

    [SerializeField]
    public AudioMixer audioMixer;

    public static AudioManager instance;

    private void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StopAllBGM()
    {
        for (int i = 0; i < bgm.Length; i++) 
            bgm[i].Stop();
    }

    public void PlayBGM(int index)
    {
        StopAllBGM();
        bgm[index].Play();
    }

    public void PlaySFX(int index)
    {
        if (i < sfx.Length)
            sfx[i].playOneShpt(SFX[i].clip);    
    }
