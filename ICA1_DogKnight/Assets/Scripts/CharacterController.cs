using UnityEngine;
using UnityEngine.AI;

public class CharacterController : MonoBehaviour
{
    public Camera camera;
    public NavMeshAgent player;
    public GameObject targetDest;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;
            
            if(Physics.Raycast(ray, out hitPoint))
            {
                targetDest.transform.position = hitPoint.point;
                player.SetDestination(hitPoint.point);
            }
        }
    }
}
