using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScriptsd : MonoBehaviour
{
    private Rigidbody2D rigid;

    [SerializeField]
    private float speed=5,Jump=250;

    private int Gold,dead;

    public bool isJump=false;

    public int RedBallHealth =5;

    private Animator anim;

    public Text GoldAmount;

    public Image[] hearts;

    public Sprite fullHeart, emptyHeart;

    public RollBox RollBox;





    void Start()
    {

        isJump = false;

        rigid = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

        RollBox = GetComponent<RollBox>();
    }


    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");

        moved(Horizontal);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isJump == false)
            {
                rigid.AddForce(new Vector2(rigid.velocity.x, Jump));

                isJump = true;

            }

        }
        if (RedBallHealth == 0)
        {
            anim.SetBool("Dead", true);

            Time.timeScale = 0 ;
            
                            
        }

        GoldAmount.text = "" + Gold;

        foreach (Image img in hearts)
        {
            img.sprite = emptyHeart;
        }

        for (int i = 0; i < RedBallHealth; i++)
        {
            hearts[i].sprite = fullHeart;
        }

        


    }
        
    
        
    

    private void moved(float Horizontal)
    {
        rigid.velocity = new Vector2(speed * Horizontal, rigid.velocity.y);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Bridge"))
        {
            isJump = false;

            anim.SetBool("RedBallisHurt", false);
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            RedBallHealth -= 1;

            anim.SetBool("RedBallisHurt", true);
                       

        }
        if (collision.gameObject.CompareTag("Gold"))
        {
            Destroy(collision.gameObject);

            Gold += 1;
        }

        if (collision.gameObject.CompareTag("GameFinish"))
        {
            SceneManager.LoadScene(2);  
        }
        




    }

   
}
