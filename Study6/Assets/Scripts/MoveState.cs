using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player.Move
{
    public class MoveState
    {
        public float movementSpeed = 3.0f;

        Vector2 m_movement = new Vector2();
        Rigidbody2D m_rb2D;
        Animator m_animator;
        readonly string m_animationState = "AnimationState"; //readonly�� ���� �������� �߻����� �ʴ´�.

        public MoveState(Animator animator, Rigidbody2D rb2D)
        {
            m_animator = animator;
            m_rb2D = rb2D;
        }

        enum CharStates
        {
            walkEast = 1,
            walkSouth = 2,
            walkWest = 3,
            walkNorth = 4,
            idleSouth = 5
        }

        public void UpdateSate()
        {
            if (m_movement.x > 0)
            {
                //���������� �̵�
                m_animator.SetInteger(m_animationState, (int)CharStates.walkEast);
            }

            else if (m_movement.x < 0)
            {
                //���� �̵�
                m_animator.SetInteger(m_animationState, (int)CharStates.walkWest);
            }

            else if (m_movement.y > 0)
            {
                //���� �̵�
                m_animator.SetInteger(m_animationState, (int)CharStates.walkNorth);
            }

            else if (m_movement.y < 0)
            {
                //���� �̵�
                m_animator.SetInteger(m_animationState, (int)CharStates.walkSouth);
            }

            else if (m_movement.x == 0 || m_movement.y == 0)
            {
                //���� �̵�
                m_animator.SetInteger(m_animationState, (int)CharStates.idleSouth);
            }
        }
        public void MoveCharacter()
        {
            m_movement.x = Input.GetAxisRaw("Horizontal"); // ������ �Է� (x��)
            m_movement.y = Input.GetAxisRaw("Vertical"); // ������ �Է� (y��)

            m_movement.Normalize();

            m_rb2D.velocity = m_movement * movementSpeed;
        }

    }
}

