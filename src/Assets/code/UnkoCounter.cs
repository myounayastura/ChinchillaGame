using UnityEngine;
using System.Collections;

public class UnkoCounter : MonoBehaviour
{
    GameObject[] tagObjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Check(string tagname){
		tagObjects = GameObject.FindGameObjectsWithTag(tagname);
		Debug.Log(tagObjects.Length);
	}
}
