using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_05_03 : MonoBehaviour
{
    public Toggle[] toggles;
    // Start is called before the first frame update
    void Start()
    {
        //toggles[0].isOn = false;
        foreach (var toogle in toggles)
        {
            toogle.onValueChanged.AddListener(delegate(bool selected)
            {
                Debug.LogFormat("toggles = {0},seleceted = {1}", toogle.name,selected);
            });
        }
        //if (toggles[0].isOn == false)
        //{
        //    toggles[3].isOn = false;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
