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
    public GameObject finish;
    public GameObject slides;



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
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        //next.GetComponent<BoxCollider>().enabled = true;


        // }
    }

    public void startSmoke()
    {
        cigarette.SetActive(true);
        cigarette1.SetActive(false);
        part.SetActive(true);
        Invoke("slideShow", 7f);
    }

    public void colorChange()
    {
        //cotton.GetComponent<Animation>().Play("Cottonball");
 
        Invoke("slideShow", 5f);
    }

    public void slideShow()
    {
        slides.SetActive(true);
        Invoke("text", 5f);
    }


    public void text()
    {
        
        finish.SetActive(true);
       
    }


    public void flameOff()
    {
        fire.SetActive(false);
    }

    
}
