using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.DefenseBasic
{
    public class Enemy : MonoBehaviour
    {
        public float speed;
        public float atkDistance;
        private Animator m_amin;
        private Rigidbody2D m_rb;
        private Player m_player;
        

        // Start is called before the first frame update
        void Start()
        {
            m_amin = GetComponent < Animator>();
            m_rb = GetComponent<Rigidbody2D>();
            m_player = FindObjectOfType<Player>();
        }

        // Update is called once per frame
        void Update()
        {
            if (m_rb == null || m_player == null) return;

          
            if(Vector2.Distance(m_player.transform.position,
                transform.position) <= atkDistance)
            {
                if (m_amin)
                    m_amin.SetBool(Const.danh_ANIM, true);

                m_rb.velocity = Vector2.zero; // (0, 0)
              
            }
            else
            {
                    m_rb.velocity = new Vector2(-speed, m_rb.velocity.y);
            }
        }
    }
}
