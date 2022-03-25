using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour
{
    public bool grabbing;
    public bool firing;
    public GameObject Ball;
    public GameObject Fuse;
    public GameObject Puff;
    public Transform PuffSpot;
    public float fireTime;

    // Update is called once per frame
    void Start()
    {
        
    }

    void Update()
    {
        if(Fuse.GetComponent<Fuse>().lit && !firing)
        {
            firing = true;
            StartCoroutine(Fire());
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Controller"))
        {   
            grabbing = true;
            var thing = Instantiate(Ball, transform.position, transform.rotation);
            Rigidbody thingRB = thing.GetComponent<Rigidbody>();
            thingRB.velocity = new Vector3(40, 20, 0);
        }
    }

    IEnumerator Fire(){
        grabbing = true;
        yield return new WaitForSeconds(Fuse.GetComponent<Fuse>().delay + 0.5f);
        var thing = Instantiate(Ball, transform.position, transform.rotation);
        Rigidbody thingRB = thing.GetComponent<Rigidbody>();
        thingRB.velocity = new Vector3(40, 20, 0);
        var puffThing = Instantiate(Puff, PuffSpot.position, PuffSpot.rotation);
        Destroy(puffThing, 0.3f);

        //yield return new WaitForSeconds(fireTime);
        Fuse.GetComponent<Fuse>().lit = false;
        firing = false;
    }
}
