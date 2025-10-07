using System.Runtime.CompilerServices;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameManager GameManager;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            GameManager.addpontos(10);
            Destroy(gameObject);
        }           
    }

}
