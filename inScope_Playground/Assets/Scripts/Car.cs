using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private GameObject[] wheels;

    [SerializeField]
    private float rotationSpeed;

    private Vector3 startPos;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        foreach (GameObject wheel in wheels)
        {
            wheel.transform.Rotate(Vector3.right * speed * Time.deltaTime, Space.Self);
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Portal")
        {
            transform.position = startPos;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().Die();
            speed = 0;
        }
    }
}