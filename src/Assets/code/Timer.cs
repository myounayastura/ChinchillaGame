using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] Text TimerText;
    float limitTime = 20; // 制限時間

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        limitTime -= Time.deltaTime;

        if (limitTime < 0)
        {
            limitTime = 0;
            SceneManager.LoadScene(2);
        }

        TimerText.text = limitTime.ToString("F0"); // 残り時間を整数で表示
    }
}