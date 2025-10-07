using UnityEditorInternal;
using UnityEngine;
using static UnityEngine.UI.Selectable;

public class Player : MonoBehaviour
{
    public Vector2 posicaoInicial;
    public GameManager GameManager;

    public Animator anim;
    private Rigidbody2D rigd;
    public float speed;
    //pulo
    public float jumpForce = 10f;
    public bool isGround;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigd = GetComponent<Rigidbody2D>();
        posicaoInicial = transform.position; //pega posi��o inicial
    }

    void Update()
    {
        Move();
        Jump();
    }
    public void ReiniciarPosi��o() 
    {
        transform.position = posicaoInicial;    
    }

    void Move()
    {
        float teclas = Input.GetAxis("Horizontal");
        rigd.linearVelocity = new Vector2(teclas * speed, rigd.linearVelocity.y);
        if (teclas > 0) {
            transform.eulerAngles = new Vector2 (0, 0);
            anim.SetInteger("transition", 1);
         }
        if (teclas < 0) {
            transform.eulerAngles = new Vector2(0, 180);
            anim.SetInteger("transition", 1);
        }
        if (teclas == 0) {
            anim.SetInteger("transition", 0);
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround) {
            rigd.AddForce(Vector2.up * jumpForce); //, ForceMode2D.Impulse);
            isGround = false;
            anim.SetInteger("transition", 2);            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tagGround")
        {
            isGround = true;
            Debug.Log("est� no ch�o");
        }

        if (collision.gameObject.tag == "fora")
        {
            GameManager.alteravida(1);
            Debug.Log("Caiu");
        }
    }

}
