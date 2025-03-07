using UnityEngine;
using TMPro;  // TextMeshProの場合

public class FPSCounter : MonoBehaviour
{
    public TextMeshProUGUI fpsText;  // UIに表示する場合
    private float deltaTime = 0.0f;

    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        if (fpsText != null)
        {
            fpsText.text = string.Format("{0:0.} FPS", fps);
        }
    }
}

