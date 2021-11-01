using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCollision : MonoBehaviour
{
    public Pin pin;
    public AudioSource tickSource;
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider otherCollider)
    {
        if (otherCollider.tag == "Floor")
        {
            pin.OnTouchFloor();
        }
        if (otherCollider.tag == "Bowl")
        {
            tickSource.Play();
        }
        if (otherCollider.tag == "Pin")
        {
            tickSource.Play();
        }
    }
}
