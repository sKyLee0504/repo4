using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public RectTransform rect;
    // Start is called before the first frame update
    void Start()
    {
        rect.GetComponent<RectTransform>();
        Debug.Log(rect.rect.height);
        Debug.Log(rect.rect.width);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
