using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RollBoxisDead : MonoBehaviour
{

    [SerializeField]
    private float RollBoxHealth;

    public bool Dead;
    
    private Animator anim;



    void Start()
    {
        Dead = false;

        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (RollBoxHealth <= 0)
        {
            Dead = true;

            Destroy(gameObject, 0.2f);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            RollBoxHealth -= 1;

            

        }

       
        
        
    }
}
