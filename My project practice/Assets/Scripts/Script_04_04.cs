using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_04_04 : MonoBehaviour
{
    private Coroutine m_coroutine = null;
    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(CreatorCube());
    }

    // Update is called once per frame
    IEnumerator CreatorCube()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = Vector3.one * i;
            yield return new WaitForSeconds(1f);
        }
    }

    private void OnGUI()
    {
        if(GUILayout.Button("StartCoroutine"))
        {
            if (m_coroutine != null)
            {
                StopCoroutine(m_coroutine);
            }
            m_coroutine = StartCoroutine(CreatorCube());
        }
        if (GUILayout.Button("StopCoroutine"))
        {
            if (m_coroutine != null)
            {
                StopCoroutine(m_coroutine);
            }
        }
    }
}   
