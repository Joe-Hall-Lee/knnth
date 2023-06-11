using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigidBody;

    [SerializeField]
    private float speed;

    [SerializeField] // This is tmp, we are going to remove this later
    private Vector3 direction;

    private float lifeTime = 10;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody.velocity = direction * speed;

        Destroy(gameObject, lifeTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}