using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactor : MonoBehaviour
{
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
        // if (other.name == "Damage")
        // {
        //     TakeDamage();
        // }

        if (other.tag == "Damage")
        {
            other.GetComponent<MeshRenderer>
                ().material.color = Color.blue;

            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    
    private void TakeDamage()
    {
        Debug.Log("Player hit!");
    }


    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Damage")
        {
            other.GetComponent<MeshRenderer>
                ().material.color = Color.red;

            GetComponent<MeshRenderer>().material.color
                = Color.blue;
        }
    }
}