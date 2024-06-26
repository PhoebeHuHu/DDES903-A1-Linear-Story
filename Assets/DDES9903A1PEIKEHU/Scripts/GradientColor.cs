using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradientColor : MonoBehaviour
{
    public float colorChangeSpeed = 2.0f; // 颜色变化速度
    public bool isChangingColor = true;
    private Renderer objectRenderer;
    public Color defaultColor = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isChangingColor)
        {
            ChangeColor();
        }
        
    }
    void ChangeColor()
    {
        float r = Mathf.Sin(Time.time * colorChangeSpeed) * 0.5f + 0.5f;
        float g = Mathf.Sin(Time.time * colorChangeSpeed + Mathf.PI / 2) * 0.5f + 0.5f;
        float b = Mathf.Sin(Time.time * colorChangeSpeed + Mathf.PI) * 0.5f + 0.5f;
        objectRenderer.material.color = new Color(r, g, b);
    }

    public void StartChanging()
    {
        isChangingColor = true;
    }

    public void StopChanging()
    {
        isChangingColor= false;
        objectRenderer.material.color = defaultColor;
    }
}
