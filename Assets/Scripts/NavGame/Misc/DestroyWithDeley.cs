using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithDeley : MonoBehaviour
{
    public float delay = 2f;
    void Start()
    {
        Destroy(gameObject, delay);
    }

    void Update()
    {
        
    }
}
