using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 現在のシーンが最初のシーン（インデックス0）でない場合
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            // 最初のシーンに移動
            SceneManager.LoadScene(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
