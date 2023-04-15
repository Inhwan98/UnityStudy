using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickMovement : MonoBehaviour
{
    private new Camera camera;
    private Animator animator;
    private NavMeshAgent agent;

    private bool isMove;
    private Vector3 destination;

    private void Awake()
    {
        camera = Camera.main;
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
    }

    void Start()
    {
       
    }


    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            RaycastHit hit;
            if(Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                SetDestination(hit.point);
            }
        }

        LookMoveDirection();
    }

    private void SetDestination(Vector3 dest)
    {
        agent.SetDestination(dest);
        destination = dest;
        isMove = true;
        animator.SetBool("isMove", true);
    }

    private void LookMoveDirection()
    {
        if (isMove)
        {
            if (agent.velocity.magnitude == 0f)
            {
                isMove = false;
                animator.SetBool("isMove", false);
                return;
            }

            var dir = new Vector3(agent.steeringTarget.x, transform.position.y, agent.steeringTarget.z) - transform.position;
            transform.forward = dir;
            //transform.position += dir.normalized * Time.deltaTime * 5f;
        }
    }
}
