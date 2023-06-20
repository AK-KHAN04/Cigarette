using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighter : MonoBehaviour
{
    public GameObject next;
    public GameObject cigarette;
    public GameObject cigarette1;
    public GameObject part;
    public GameObject fire;



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
        //if (other.tag == "Stand")
       // {
        Debug.Log("funnel");
        this.gameObject.GetComponent<Animator>().enabled = true;
        fire.SetActive(true);
        //next.GetComponent<BoxCollider>().enabled = true;


        // }
    }

    public void startSmoke()
    {
        cigarette.SetActive(true);
        cigarette1.SetActive(false);
        part.SetActive(true);

    }

}
