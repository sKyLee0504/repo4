using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_06 : MonoBehaviour
{
    public float updateInterval = 0.5F;
    private float accum = 0;
    private int frames = 0;
    private float timeleft;
    private string stringFps;
    // Start is called before the first frame update
    void Start()
    {
        timeleft = updateInterval;
        // Application.targetFrameRate = (int)30f;//强制设置FPS最高30帧
    }

    // Update is called once per frame
    void Update()
    {
        // 记一个初始时间，接着取当前时间减去初始时间，这期间Update执行的次数就是FPS
        timeleft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        ++frames;
        if (timeleft <= 0.0)
        {
            float fps = accum / frames;
            string format = System.String.Format("{0:F2} FPS", fps);
            stringFps = format;
            timeleft = updateInterval;
            accum = 0.0F;
            frames = 0;
        }
    }
    void OnGUI()
    {
        GUIStyle guiStyle = GUIStyle.none;
        guiStyle.fontSize = 30;
        guiStyle.normal.textColor = Color.red;
        guiStyle.alignment = TextAnchor.UpperLeft;
        Rect rt = new Rect(140, 0, 100, 100);
        GUI.Label(rt, stringFps, guiStyle);
    }
}
