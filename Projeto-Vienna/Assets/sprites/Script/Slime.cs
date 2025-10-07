using System.Runtime.CompilerServices;
using UnityEngine;

public class slime : MonoBehaviour
{
    public GameManager GameManager;
    void Start()
    {

    }
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.alteravida(1);
        }
    }

}
