using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConstantScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float c_width = Screen.width / 1024.0f;
        float c_height = Screen.height / 1024.0f;

        GetComponent<CanvasScaler>().scaleFactor = c_width;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
