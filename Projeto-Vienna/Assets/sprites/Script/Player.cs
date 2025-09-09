using UnityEditorInternal;
using UnityEngine;
using static UnityEngine.UI.Selectable;

public class Player : MonoBehaviour
{
    public Animator anim;
    private Rigidbody2D rigd;
    public float speed;

    public float jumpForce = 10f;
    public bool isGround;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigd = GetComponent<Rigidbody2D>();
      
    }

    void Update()
    {
        Move();
        Jump();
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
        if ((teclas == 0) && (isGround = true)) {
            anim.SetInteger("transition", 0);
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (isGround = true)) {
            rigd.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            anim.SetInteger("transition", 2);
            isGround = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tagGround")
        {
            isGround = true;
            Debug.Log("está no chão");
        }
    }
}
