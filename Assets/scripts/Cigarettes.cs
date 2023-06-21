using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cigarettes : MonoBehaviour
{

    public GameObject next;

    public GameObject prevcoll;
    public GameObject nextcoll;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Animator>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        this.gameObject.GetComponent<Animator>().enabled = true;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        next.GetComponent<BoxCollider>().enabled = true;
        Debug.Log("Hello world");

        prevcoll.GetComponent<BoxCollider>().enabled = false;
        nextcoll.GetComponent<BoxCollider>().enabled = true;

    }
}
