using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVFX : MonoBehaviour
{
    private float time = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, time);
    }

    
}
