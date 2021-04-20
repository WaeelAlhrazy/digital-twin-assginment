using UnityEngine;
using UnityEngine.AI;

public class VehicleController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
     //public float goalDistance = 40f;

    // Start is called before the first frame update
  /* void Start()
    {
       

       Vector3 target = transform.position + Vector3.forward * goalDistance;
       agent.SetDestination(target);

    }*/
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
