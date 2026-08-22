using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Loding : MonoBehaviour
{
    [SerializeField]
    private Slider slider;

    [SerializeField]
    private float waitSeconds = 1f;

    void Start()
    {
       
    }  

    void Update()
    {
        if (waitSeconds > 0f)
        {
            waitSeconds -= Time.deltaTime;

        }
        else
        {
            StartCoroutine(LoadNewScene());
        }

        private IEnumerator LoadNewScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Scene01");
        while (!asyncLoad.isDone)
        {
            slider.value = oper.progress / 0.9f;
            yield return null;
        }
    }
}
