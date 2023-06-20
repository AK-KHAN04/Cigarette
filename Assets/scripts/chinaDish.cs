using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chinaDish : MonoBehaviour
{

    public GameObject next;
    public Animator animator;
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
        if(other.tag == "Stand")
        {
            Debug.Log("chinaDish");
            this.GetComponent<Collider>().enabled = false;
            next.GetComponent<Collider>().enabled = true;
            this.GetComponent<ObjectPicker>().enabled = false;
            animator.enabled = true;
        }
    }
}
