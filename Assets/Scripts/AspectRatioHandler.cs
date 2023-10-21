using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AspectRatioHandler : MonoBehaviour
{
    public CanvasScaler canvasScaler;

    void Start()
    {
        float aspectRatio = (float)Screen.width / Screen.height;

        if (aspectRatio > 16f / 9f) // Wider than 16:9
        {
            canvasScaler.matchWidthOrHeight = 1.0f;
        }
        else
        {
            canvasScaler.matchWidthOrHeight = 0.0f;
        }
    }
}

