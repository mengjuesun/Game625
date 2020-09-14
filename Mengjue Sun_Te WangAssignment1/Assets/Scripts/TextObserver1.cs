using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TextObserver1 : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {
        SubjectObs.ObserverTestEvent += ChangeText;
    }

    private void ChangeText()
    {
        Text txt = transform.Find("Text1").GetComponent<Text>();
        txt.text = "Let's Pick Up!";
    }

    void OnDestroy()
    {
        SubjectObs.ObserverTestEvent -= ChangeText;
    }
}