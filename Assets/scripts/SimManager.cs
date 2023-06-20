using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] objects;
    void Start()
    {
        foreach (GameObject i  in objects){
            i.GetComponent<Collider>().enabled = false;
        }

        objects[0].GetComponent<Collider>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

