using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CottonBall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject next;
    public GameObject coll;
    public GameObject nextcoll;
    public GameObject stick;
    

    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Stand")
        // {
        Debug.Log("funnel");
        this.gameObject.GetComponent<Animator>().enabled = true;
        this.gameObject.GetComponent<ObjectPicker>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;

        next.GetComponent<Button>().interactable = true;
        coll.GetComponent<BoxCollider>().enabled = false;
        stick.GetComponent<BoxCollider>().enabled = true;
       


        // }
    }


    private void animatoroff()
    {
        this.gameObject.GetComponent<Animator>().enabled = false;
    }

    public void anim()
    {
        stick.GetComponent<Animator>().enabled = false;
    }
}
