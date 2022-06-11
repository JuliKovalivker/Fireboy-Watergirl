using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay()
    {
        Destroy(gameObject, 0.1f);
    }
}
