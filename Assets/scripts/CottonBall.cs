using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CottonBall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject next;
    public GameObject coll;
    public GameObject nextcoll;
    

    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Stand")
        // {
        Debug.Log("funnel");
        this.gameObject.GetComponent<Animator>().enabled = true;
        this.gameObject.GetComponent<ObjectPicker>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        next.GetComponent<BoxCollider>().enabled = true;

        coll.GetComponent<BoxCollider>().enabled = false;
        nextcoll.GetComponent<BoxCollider>().enabled = true;


        // }
    }


    private void animatoroff()
    {
        this.gameObject.GetComponent<Animator>().enabled = false;
    }
}
