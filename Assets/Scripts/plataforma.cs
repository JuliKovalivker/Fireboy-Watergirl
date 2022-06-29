using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    AudioSource audio_;

    // Start is called before the first frame update
    void Start()
    {
        audio_ = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "player")
            audio_.Play();
        {

        }
    }
}
