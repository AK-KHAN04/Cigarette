using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spoon : MonoBehaviour
{

    public GameObject next;
    public Animator anim;
    public GameObject sphere;
    public GameObject sphere2;


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
        if (other.tag == "bottleTop")
        {
            anim.enabled = true;
            Debug.Log("spoon on bottle top1");
            this.GetComponent<ObjectPicker>().enabled = false;
            this.GetComponent<Collider>().enabled = false;
            this.GetComponent<ObjectPicker>().enabled = false;
            next.GetComponent<Collider>().enabled = true;
            Invoke("sphereActive", 0.90f);
            Invoke("sphereAnimation", 2.10f);
        }
    }

    void sphereAnimation()
    {
       // sphere.GetComponent<Animator>().enabled = true;
       sphere.SetActive(false);
       sphere2.SetActive(true);
        
    }

    void sphereActive()
    {
        sphere.SetActive(true);
    }
}
