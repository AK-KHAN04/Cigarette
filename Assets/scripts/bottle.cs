using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottle : MonoBehaviour
{

    public GameObject next;
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
        this.GetComponent<ObjectPicker>().enabled = false;
        Debug.Log("bottle");
        this.GetComponent<Collider>().enabled = false;
        next.GetComponent<Collider>().enabled = true;
    }
}
