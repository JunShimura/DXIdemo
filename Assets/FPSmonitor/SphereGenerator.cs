using TMPro;
using UnityEditor;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    public GameObject prefab;
    public float r;
    public float rate=0;
    float t=0.0f;
    [SerializeField]TextMeshProUGUI countMonitor;
    int count =0;

    // Update is called once per frame
    void Update()
    {
       t+=Time.deltaTime;
       if(t>rate){
        var go = GameObject.Instantiate(prefab,Random.insideUnitSphere*r+this.transform.position,Quaternion.identity);
        go.transform.localScale=Vector3.one*Random.Range(0.5f,1.5f); 
        go.GetComponent<Rigidbody>().AddTorque(Random.insideUnitSphere*100.0f);
        t=0;
        count++;
        countMonitor.text = count.ToString("N0");
       }
    }
}
