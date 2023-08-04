using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RollBox : MonoBehaviour
{
    private Rigidbody2D rigid;

    [SerializeField]
    private float speed;

    [SerializeField]
    public float RollBoxHealth = 1;

    public RollBoxisDead RollBoxisDead;

    public Animator anim;

    public PlayerScriptsd RedBall;

    public bool Dead;

    
    void Start()
    {

        
        rigid = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");


        if(RollBoxisDead.Dead == true)
        {
            anim.SetBool("Dead", true);

            Destroy(gameObject, 0.2f);

        }

        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.CompareTag("Enemy"))

        {
            RedBall.RedBallHealth -= 1;

            

        }
    }









}
