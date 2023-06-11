using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilPrefab;

    [SerializeField]
    private GameObject[] gunBarrels;

    [SerializeField]
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(int index)
    {
        Instantiate(projectilPrefab, gunBarrels[index].transform.position, Quaternion.identity);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("Shoot", true);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("Shoot", false);
        }
    }
}