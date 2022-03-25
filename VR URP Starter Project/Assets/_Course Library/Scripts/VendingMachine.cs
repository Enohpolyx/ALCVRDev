using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendingMachine : MonoBehaviour
{
    public float speed;
    public GameObject Yeet;
    public GameObject Product;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Dollar")){
            var product = Instantiate(Product, Yeet.transform.position, Yeet.transform.rotation);
            Rigidbody productRB = product.GetComponent<Rigidbody>();
            productRB.velocity = new Vector3(-speed, 0, 0);
        }
    }
}
