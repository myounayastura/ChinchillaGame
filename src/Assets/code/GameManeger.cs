using UnityEngine;
using System.Collections.Generic;

public class GameManeger : MonoBehaviour
{
    public static GameManeger instance = null;
    public GameObject Chinchilla;
    public GameObject unko;
    GameObject[] tagObjects;
    public static List<GameObject> unkoList = new List<GameObject>();
    public int unkoCount_old = 0;

    void Awake(){
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else{
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(Chinchilla != null){
            Vector3 position = Chinchilla.transform.position;
            if(Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
            {
                unkoList.Add(Instantiate(unko, position, Quaternion.identity));
                Check("Unko");
            }

            if(unkoList.Count != unkoCount_old){ 
                Check("Unko");
            }
        }
    }

    public void Check(string tagname){
		//tagObjects = GameObject.FindGameObjectsWithTag(tagname);
		Debug.Log(unkoList.Count);
        unkoCount_old = unkoList.Count;
    }
}
