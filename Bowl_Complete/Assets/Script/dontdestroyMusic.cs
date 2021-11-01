using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroyMusic : MonoBehaviour
{
    private GameObject[] music;
    // Start is called before the first frame update
    void Start()
    {
        music = GameObject.FindGameObjectsWithTag("music");
        Destroy (music[1]);
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
