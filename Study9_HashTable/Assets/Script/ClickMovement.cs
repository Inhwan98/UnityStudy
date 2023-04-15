using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickMovement : MonoBehaviour
{
    public static ClickMovement instance = null;

    private new Camera camera;
    private CameraController CameraCtrl;
    private Animator animator;
    private NavMeshAgent agent;

    private bool isMove;
    private Vector3 destination;
    RaycastHit hit;

    public bool isShop;

    // 반응 속도
    public float damping = 10.0f;
    // SmoothDamp에서 사용할 변수
    private Vector3 velocity = Vector3.zero;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        camera = Camera.main;
        CameraCtrl = CameraController.instance;
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;

    }

    void Start()
    {
        isShop = false;
    }


    void Update()
    {
        if(Input.GetMouseButton(1) && !isShop)
        {
            if(Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                SetDestination(hit.point);
            }
        }

        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(transform.position, transform.forward, out hit, 3.0f, 1 << 3))
            {
                if (Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out hit))
                {
                    if (hit.transform.CompareTag("Box"))
                    {
                        Transform pos = hit.transform.Find("camPos").transform;

                        CameraCtrl.ChangeTarget(pos, hit.transform);
                        isShop = true;
                    }
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isShop = false;
            CameraCtrl.isOtherUse = false;
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
            if (agent.velocity.magnitude == 0.0f)
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
