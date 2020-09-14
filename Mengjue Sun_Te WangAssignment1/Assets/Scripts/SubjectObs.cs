using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public delegate void ObserverTest();

public class SubjectObs : MonoBehaviour
{
    public static event ObserverTest ObserverTestEvent;


    void Start()
    {
        Button btn = transform.Find("Button").GetComponent<Button>();
        btn.onClick.AddListener(onClick);
    }

    public void onClick()
    {
        if (ObserverTestEvent != null)
            ObserverTestEvent();
    }

}
