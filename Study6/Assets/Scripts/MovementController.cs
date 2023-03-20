using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player.Move
{
    public class MovementController : MonoBehaviour
    {
        Animator animator;
        Rigidbody2D rb2D;
        MoveState moveState;

        private void Start()
        {
            animator = this.GetComponent<Animator>();
            rb2D = this.GetComponent<Rigidbody2D>();

            moveState = new MoveState(animator, rb2D);
        }

        private void Update()
        {
            moveState.UpdateSate();
        }

        private void FixedUpdate()
        {
            moveState.MoveCharacter();
        }
        
    }
}

