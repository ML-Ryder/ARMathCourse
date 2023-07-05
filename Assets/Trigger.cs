using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject D1;
    public GameObject D2;
    public float X;
    public float Y;
    public GameObject Sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Sphere.transform.position = new Vector3(this.transform.parent.transform.position.x+X, this.transform.parent.transform.position.y+Y, this.transform.parent.transform.position.z - 4.186325f);
        D1.SetActive(false);
        D2.SetActive(true);
    }
}
