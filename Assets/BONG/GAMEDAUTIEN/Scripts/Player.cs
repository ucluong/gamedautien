using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.DefenseBasic
{
    public class Player : MonoBehaviour

    {
        public float atkRate;
        private Animator m_anim;
        private float m_curAtkRate;
        private bool m_isatack;


        private void Awake()
        {
            m_anim = GetComponent<Animator>();
            m_curAtkRate = atkRate;
        }


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0) && !m_isatack)
            {
                if (m_anim)
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
            if (m_anim)
                m_anim.SetBool(Const.danh_ANIM, false);
        }

    }
}
   
