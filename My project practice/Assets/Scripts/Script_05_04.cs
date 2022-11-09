using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_05_04 : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        // …Ë÷√»°÷µ∑∂Œß
        slider.minValue = 0;
        slider.maxValue = 100;

        slider.onValueChanged.AddListener(delegate (float value)
        {
            Debug.LogFormat("value = {0}", value);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
