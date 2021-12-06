using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFall : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.angularVelocity = Random.insideUnitSphere.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
