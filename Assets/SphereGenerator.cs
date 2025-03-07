using UnityEditor;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    public GameObject prefab;
    public float r;
    public float rate=0;
    float t=0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       t+=Time.deltaTime;
       if(t>rate){
        GameObject.Instantiate(prefab,Random.insideUnitSphere*r+this.transform.position,Quaternion.identity);
        t=0;
       }
    }
}
