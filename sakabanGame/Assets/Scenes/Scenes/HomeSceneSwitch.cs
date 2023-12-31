using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeSceneSwitch : MonoBehaviour
{
    public AudioClip selectSE;            // Spaceを押したときの音
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.PlayOneShot(selectSE);

        // タイトルからセレクトへ
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("StageSelectScene");
        }

        // ホームからタイトルへ
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
