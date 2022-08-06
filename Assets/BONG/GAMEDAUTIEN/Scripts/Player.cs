using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.DefenseBasic
{
 
    public class Player : MonoBehaviour, ChecKing

    {
        public float atkRate;
        private Animator m_anim;
        private float m_curAtkRate;
        private bool m_isatack;
        private bool m_isDesd;


        private void Awake()
        {
            m_anim = GetComponent<Animator>();
            m_curAtkRate = atkRate;
        }


        // Start is called before the first frame update
        void Start()
        {

        }

        public bool IsComponentsNull()
        {
            return m_anim == null;
        }

        // Update is called once per frame
        void Update()
        {
            if (IsComponentsNull()) return;

            if (Input.GetMouseButtonDown(0) && !m_isatack)
            {
                
                m_anim.SetBool(Const.danh_ANIM, true);
                m_isatack = true;
            }
            if (m_isatack)
            {
                m_curAtkRate -= Time.deltaTime;

                if (m_curAtkRate <= 0)
                {
                    m_isatack = false;

                    m_curAtkRate = atkRate;
                }
            }

        }
        public void ResetAtkAnim()
        {
            if (IsComponentsNull()) return;

             m_anim.SetBool(Const.danh_ANIM, false);
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (IsComponentsNull()) return;

            if (col.CompareTag(Const.ENEMY_WEAPON_TAG) && !m_isDesd )
            {
                
                m_anim.SetTrigger(Const.chet_ANIM);
                
            }
        }

    }
}
   
