using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ButtonObserver : MonoBehaviour
{
    void Start()
    {
        SubjectObs.ObserverTestEvent += ChangeButton;
    }

    public void ChangeButton()
    {
        Button btn = transform.Find("Button1").GetComponent<Button>();
        Image image = btn.GetComponent<Image>();
        Text txt = btn.transform.Find("Text").GetComponent<Text>();

        image.color = Color.red;
        txt.text = "Power Up!";
    }

    void OnDestroy()
    {
        SubjectObs.ObserverTestEvent -= ChangeButton;

    }
}