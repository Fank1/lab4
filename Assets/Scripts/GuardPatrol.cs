using UnityEngine;
using UnityEngine.AI;

public class GuardPatrol : MonoBehaviour
{
    public Transform player;

    public float patrolSpeed = 3.5f;
    public float chaseSpeed = 5.5f;
    public float chaseRange = 5f;
    public float loseRange = 7f;
    
    public Transform[] waypoints;
    public float waypointTolerance = 0.5f;

    private int _currentIndex = 0;
    private NavMeshAgent _agent;

    

    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void StartPatrol()
    {
        if (waypoints.Length > 0)
        {
            _agent.SetDestination(waypoints[_currentIndex].position);
        }
    }

    void UpdatePatrol()
    {
        if (waypoints.Length == 0)
        {
            return;
        }

        _agent.speed = patrolSpeed;

        if (!_agent.pathPending && _agent.remainingDistance <= waypointTolerance)
        {
            _currentIndex = (_currentIndex + 1) % waypoints.Length;
            _agent.SetDestination((waypoints[_currentIndex].position));
        }
    }

    void UpdateChase()
    {
        _agent.speed = chaseSpeed;
        _agent.SetDestination(player.position);

    }

  

    void Update()
    {
    }
}
