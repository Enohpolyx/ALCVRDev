using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse : MonoBehaviour
{
    public bool lit;
    public float delay;
    public GameObject Sparks;
    // Start is called before the first frame update
    void Awake()
    {
        lit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Torch"))
        {   
            lit = true;
            var spark = Instantiate(Sparks, transform.position, new Quaternion(0,-90,-90,0));
            Destroy(spark, delay);
        }
    }
}
