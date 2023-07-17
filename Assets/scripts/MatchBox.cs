using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchBox : MonoBehaviour
{
    public GameObject stick;
    public GameObject standMid;
    // Start is called before the first frame update
    void Start()
    {
        stick.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StickActive()
    {
        stick.SetActive(true);
        standMid.GetComponent<Collider>().enabled = true;
        Invoke("anim", 2f);
    }

    public void anim()
    {
        stick.GetComponent<Animator>().enabled = false;
    }
}
