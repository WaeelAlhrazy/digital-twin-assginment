using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BicycleController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public Transform goal; //list of destinations as objects
    //public Transform spawn;

    public static List<Vector3> DestinationList = new List<Vector3>()
    {
        new Vector3(-13, 1, 24),
        new Vector3(-46, 1, -4),
        new Vector3(-18, 1, -35),
        new Vector3(14, 1, -8)
    };

    // Start is called before the first frame update
    void Start()
    {

        ////NavMeshAgent agent = Instantiate(prefab, spawn.position, Quaternion.identity);

        if (agent.name == "Bicycle1")
        {
            agent.destination = DestinationList[0];
        }
        else if (agent.name == "Bicycle2")
        {
            agent.destination = DestinationList[1];
        }
        else if (agent.name == "Bicycle3")
        {
            agent.destination = DestinationList[2];
        }
        else if (agent.name == "Bicycle4")
        {
            agent.destination = DestinationList[3];
        }

        Debug.Log("Agent: " + agent.name);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;

        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        agent.SetDestination(hit.point);
        //    }
        //}

    }
}
