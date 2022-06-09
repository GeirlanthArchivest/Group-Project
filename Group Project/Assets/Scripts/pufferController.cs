using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pufferController : MonoBehaviour
{
    private Animator anim;
    public float lookRadius = 10f;
    public Transform[] waypoints;
    int waypointsIndex;
    Vector3 target2;
    bool patrol = true;

    Transform target;
    NavMeshAgent agent;
        
    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.Player.transform;
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 

        float distance2 = Vector3.Distance(target.position, transform.position);

        if (distance2 <= lookRadius)
        {
            patrol = false;
            agent.SetDestination(target.position);
            anim.SetBool("inRange", true);
        }
        else
        {
            patrol = true;
            anim.SetBool("inRange", false);
        }
        if (patrol == true)
        {
            if (Vector3.Distance(transform.position, target2) < 4)
            {
                IterateWaypointIndex();
                UpdateDestination();
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    void UpdateDestination()
    {
        target2 = waypoints[waypointsIndex].position;
        agent.SetDestination(target2);
    }

    void IterateWaypointIndex()
    {
        waypointsIndex++;
        if (waypointsIndex == waypoints.Length)
        {
            waypointsIndex = 0;
        }
    }
}
