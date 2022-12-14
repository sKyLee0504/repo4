using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UGUIEventListener : UnityEngine.EventSystems.EventTrigger
{

public UnityAction<GameObject> onClick;

    public override void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
    {
        base.OnPointerClick(eventData);

        if (onClick != null)
        {
            onClick(gameObject);
        }

    }

    ///<summary>
    ///获取或者添加UGUIEventListener脚本来实现对游戏对象的监听
    ///</summary>
    static public UGUIEventListener Get(GameObject go)
    {
        UGUIEventListener listener = go.GetComponent<UGUIEventListener>();
        if (listener == null)
            listener = go.AddComponent<UGUIEventListener>();
        return listener;
    }

}