using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TrafficController : MonoBehaviour
{
   
   // public Transform entryA;

    public GameObject RedLight;
    public GameObject Greenlight;
    public GameObject YellowLight;

   // private NavMeshAgent agentA;

    // Start is called before the first frame update
    void Start()
    {
        ControlVehicleMovements();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ControlVehicleMovements()
    {
        if (RedLight == true)
        {
            GetComponent<Collider>().enabled = false;
        }
        else if(Greenlight == true)
        {
            GetComponent<Collider>().enabled = true;
        }
    }
}
