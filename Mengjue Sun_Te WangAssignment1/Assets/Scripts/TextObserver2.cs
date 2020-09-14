using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TextObserver2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        SubjectObs.ObserverTestEvent += ChangeText;
    }

    private void ChangeText()
    {
        Text txt = transform.Find("Text2").GetComponent<Text>();
        txt.text = "GoGoGo!!";
    }


    void OnDestroy()
    {
        SubjectObs.ObserverTestEvent -= ChangeText;
    }
}
