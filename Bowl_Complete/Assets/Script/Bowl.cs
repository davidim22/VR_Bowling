using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowl : MonoBehaviour
{
    public bool pin_fall = false;
    public Bowl bowl;
    void Start()
    {

    }

    void Update()
    {
        
    }
    void OnTriggerEnter (Collider otherCollider)
    {
        if (otherCollider.tag == "Pin")
        {
            pin_fall = true;
        }
    }
}
