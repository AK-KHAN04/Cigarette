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
    public GameObject cotton;
    public GameObject canvas;
    public GameObject finsh;



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
        cotton.GetComponent<MeshRenderer>().material.color = Color.red;
        part.SetActive(true);
        Invoke("colorChange",2f);
    }

    public void colorChange()
    {
        //cotton.GetComponent<Animation>().Play("Cottonball");
        Debug.Log("color changed");
        cotton.GetComponent<MeshRenderer>().enabled = false;
        Invoke("Canvas", 2f);
    }

    public void Canvas()
    {
        canvas.SetActive(true);
        Invoke("text", 2f);
    }

    public void text()
    {
        finsh.SetActive(true);
    }

}
