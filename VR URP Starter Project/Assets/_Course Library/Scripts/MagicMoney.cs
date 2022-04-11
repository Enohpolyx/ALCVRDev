using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicMoney : MonoBehaviour
{
    public Transform Maker1;
    public Transform Maker2;
    public Transform Maker3;
    public GameObject Money;
    public GameObject Sparkles;
    public int monies;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    async void OnTriggerEnter(Collider other){
        string lastUsed = "3";
        
        for(int i=0; i<monies; i++){
            
            if(lastUsed == "3")
            {
                Instantiate(Money, Maker1.position, Maker1.rotation);
                lastUsed = "1";
            }
            
            else if(lastUsed == "1")
            {
                Instantiate(Money, Maker2.position, Maker2.rotation);
                lastUsed = "2";
            }
            
            else if(lastUsed == "2")
            {
                Instantiate(Money, Maker3.position, Maker3.rotation);
                lastUsed = "3";
            }
        }
    }
}
