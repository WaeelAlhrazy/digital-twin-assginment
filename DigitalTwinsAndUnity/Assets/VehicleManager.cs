using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VehicleManager : MonoBehaviour
{
    public Transform exitA;
    public Transform exitB;
    public Transform exitC;
    public Transform exitD;

    public Transform entryA;
    public Transform entryB;
    public Transform entryC;
    public Transform entryD;

    public NavMeshAgent prefabA;
    public NavMeshAgent prefabB;
    public NavMeshAgent prefabC;
    public NavMeshAgent prefabD;

    private NavMeshAgent agentA;
    private NavMeshAgent agentB;
    private NavMeshAgent agentC;
    private NavMeshAgent agentD;

    public static int cycle = 0;

    // Start is called before the first frame update
    void Start()
    {
        InitialVehicleInstatiation();
    }

    // Update is called once per frame
    void Update()
    {
        // CheckVehicleArrival(agentA, entryA);
        // CheckVehicleArrival(agentB, entryB);
        // CheckVehicleArrival(agentC, entryC);
        // CheckVehicleArrival(agentD, entryD);
    }

    void InitialVehicleInstatiation (){
        agentA = Instantiate(prefabA, entryA.position, Quaternion.identity);
        agentB = Instantiate(prefabB, entryB.position, Quaternion.identity);
        agentC = Instantiate(prefabC, entryC.position, Quaternion.identity);
        agentD = Instantiate(prefabD, entryD.position, Quaternion.identity);

        agentA.destination = exitA.position;
        agentB.destination = exitB.position;
        agentC.destination = exitC.position;
        agentD.destination = exitD.position;
    }

    // void CheckVehicleArrival(NavMeshAgent agent, Transform entry){
    //     if (agent){
    //         if (!agent.pathPending){
    //             if (agent.remainingDistance <= agent.stoppingDistance)
    //             {
    //                 if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
    //                 {
    //                     // Done
    //                     Debug.Log("Hello, erdha une!");
    //                     Destroy(agent);
    //                     InstantiateVehicle(entry);
    //                 }
    //             }
    //         }
    //     }
    // }

    void InstantiateVehicle(Transform entry){
        var prefab = PickRandomPrefab();
        var agent = Instantiate(prefab, entry.position, Quaternion.identity);

// entryA -> exitA, exitB, exitC
// entryB -> exitB, exitC, exitD
// entryC -> exitC, exitD, exitA
// entryD -> exitD, exitA, exitB
        agent.destination = exitA.position;
    }

    void UpdateCycle() {
        if (cycle == 3)
            cycle = 0;
        else
            cycle++;
    }

    private NavMeshAgent PickRandomPrefab(){
        //  var random = new Random();
        //  var list = new List<NavMeshAgent>{ prefabA,prefabB,prefabC,prefabD};
        //  return list[random.Next(list.Count)];

         return prefabB;
    }

    void OnCollisionEnter(Collision c) {
        if(c.collider.tag == "ExitA"){
             Debug.Log("Hello, ku je?!");
            Destroy(agentA);
        }
    }

}
