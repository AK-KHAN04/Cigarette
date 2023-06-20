using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cap : MonoBehaviour
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
        if(other.tag == "CapDown")
        {
            Debug.Log("Cap");
            this.GetComponent<ObjectPicker>().enabled = false;
            this.GetComponent<Collider>().enabled = false;
            this.GetComponent<ObjectPicker>().enabled = false;
            next.GetComponent<Collider>().enabled = true;
        }
    }


}