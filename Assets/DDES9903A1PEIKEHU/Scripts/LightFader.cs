using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFader : MonoBehaviour
{
    public Light mainLight; // 主灯光
    public float fadeDuration = 5.0f; // 渐变时间

    private float startTime;

    void Start()
    {
        if (mainLight == null)
        {
            mainLight = RenderSettings.sun;
        }

        mainLight.intensity = 0f; // 初始亮度设置为0
        startTime = Time.time; // 记录开始时间
    }

    void Update()
    {
        float elapsed = Time.time - startTime;

        if (elapsed < fadeDuration)
        {
            float normalizedTime = elapsed / fadeDuration; // 计算渐变进度
            mainLight.intensity = Mathf.Lerp(0f, 1f, normalizedTime); // 从0渐变到1
        }
        else
        {
            mainLight.intensity = 1f; // 最终亮度为1
            this.enabled = false; // 关闭脚本
        }
    }
}