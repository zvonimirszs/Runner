using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerPickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {            
            //if (Input.GetKeyDown(KeyCode.E))
            //{
                //Debug.Log("Locker");
                FindObjectOfType<DeathHandler>().HandleLevel();
            //}
        }
    }
}
