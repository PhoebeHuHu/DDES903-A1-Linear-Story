using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleManager : MonoBehaviour
{
    public TextMeshProUGUI subtitleText;         // 用于显示字幕的Text组件
    public GameObject panel;          // 引用的Panel
    public string[] subtitles;        // 字幕数组
    public float timeInterval = 3f;   // 时间间隔

    private int currentIndex = 0;

    void Start()
    {
        panel.SetActive(false);       // 初始化时隐藏Panel
    }

    public void StartSubtitles()
    {
        StartCoroutine(ShowSubtitles());
    }
    public IEnumerator ShowSubtitles()
    {
        panel.SetActive(true);        // 显示Panel
        while (currentIndex < subtitles.Length)
        {
            subtitleText.text = subtitles[currentIndex];
            yield return new WaitForSeconds(timeInterval);
            currentIndex++;
        }
        subtitleText.text = "";       // 清空字幕
        panel.SetActive(false);       // 隐藏Panel
    }
}
