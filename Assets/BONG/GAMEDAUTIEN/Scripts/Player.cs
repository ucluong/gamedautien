using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator m_anim;

    private void Awake()
    {
        m_anim = GetComponent<Animator>();
    }
    
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("nguoi choi da bam chuot trai");
        }
    }
}
