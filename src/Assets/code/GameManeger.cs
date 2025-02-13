using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public GameObject Chinchilla;
    public GameObject unko;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = Chinchilla.transform.position;
        if(Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Instantiate(unko, position, Quaternion.identity);
        }
    }
}
