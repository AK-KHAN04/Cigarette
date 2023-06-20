using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funnel1 : MonoBehaviour
{

    public Animator anim;
    public GameObject next;

    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Stand")
        // {
        Debug.Log("funnel");
        anim.enabled = true;
        this.gameObject.GetComponent<ObjectPicker>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        next.GetComponent<BoxCollider>().enabled = true;

        // }
    }


    private void animatoroff()
    {
        this.gameObject.GetComponent<Animator>().enabled = false;
    }

}
