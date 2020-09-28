using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class TimerTimer : MonoBehaviour
{
    public float timer =10;
    public GameObject t;
    // Use this for initialization
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            t.GetComponent<Text>().text = timer.ToString("00");
        }
        else GameOver();

    }
    void GameOver()
    {
        t.GetComponent<Text>().text = "Gameover";
        SceneManager.LoadScene("GameMenu");
    }
}
