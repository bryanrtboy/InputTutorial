// ClickToMove.cs
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class ClickToMove : MonoBehaviour
{
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (InputGameManager.instance.m_okToMove)
        {
            agent.destination = InputGameManager.instance.GetDestinationPoint();
        }
    }
}