using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject cubo;
    AudioSource audio_;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cubo);
        audio_ = GetComponent<AudioSource>();
        audio_.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
