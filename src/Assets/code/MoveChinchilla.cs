using UnityEngine;

public class MoveChinchilla : MonoBehaviour
{
    public float speed = 1.0f;
    public float scale = 0.4f;

    void Update()
    {
        Vector3 pos = this.gameObject.transform.position;
        Vector3 scale = transform.localScale;

        if(pos.x < -2.5){
            speed *= -1;
            scale.x *= -1;
        }
        else if(pos.x > 2.5){
            speed *= -1;
            scale.x *= -1;
        }
        //現在の位置からx方向に1移動する
        this.gameObject.transform.position = new Vector3(pos.x+speed,pos.y,pos.z);
        transform.localScale = scale;

    }
}
