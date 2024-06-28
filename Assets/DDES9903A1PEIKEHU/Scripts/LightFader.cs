using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFader : MonoBehaviour
{
    public Light mainLight; // ���ƹ�
    public float fadeDuration = 5.0f; // ����ʱ��

    private float startTime;

    void Start()
    {
        if (mainLight == null)
        {
            mainLight = RenderSettings.sun;
        }

        mainLight.intensity = 0f; // ��ʼ��������Ϊ0
        startTime = Time.time; // ��¼��ʼʱ��
    }

    void Update()
    {
        float elapsed = Time.time - startTime;

        if (elapsed < fadeDuration)
        {
            float normalizedTime = elapsed / fadeDuration; // ���㽥�����
            mainLight.intensity = Mathf.Lerp(0f, 1f, normalizedTime); // ��0���䵽1
        }
        else
        {
            mainLight.intensity = 1f; // ��������Ϊ1
            this.enabled = false; // �رսű�
        }
    }
}