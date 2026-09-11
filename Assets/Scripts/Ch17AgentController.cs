using UnityEngine;
using UnityEngine.AI;

public class Ch17AgentController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator anim;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        Vector3 velocity = agent.velocity;
        anim.SetFloat("Speed", velocity.magnitude);
    }
}
