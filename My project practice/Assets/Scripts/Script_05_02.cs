using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_05_02 : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(printLog);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void printLog()
    {
        Debug.Log("µã»÷£¡");
    }
}
