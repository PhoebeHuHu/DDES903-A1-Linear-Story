using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleManager : MonoBehaviour
{
    public TextMeshProUGUI subtitleText;         // ������ʾ��Ļ��Text���
    public GameObject panel;          // ���õ�Panel
    public string[] subtitles;        // ��Ļ����
    public float timeInterval = 3f;   // ʱ����

    private int currentIndex = 0;

    void Start()
    {
        panel.SetActive(false);       // ��ʼ��ʱ����Panel
    }

    public void StartSubtitles()
    {
        StartCoroutine(ShowSubtitles());
    }
    public IEnumerator ShowSubtitles()
    {
        panel.SetActive(true);        // ��ʾPanel
        while (currentIndex < subtitles.Length)
        {
            subtitleText.text = subtitles[currentIndex];
            yield return new WaitForSeconds(timeInterval);
            currentIndex++;
        }
        subtitleText.text = "";       // �����Ļ
        panel.SetActive(false);       // ����Panel
    }
}
