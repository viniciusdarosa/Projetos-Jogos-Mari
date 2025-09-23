using System.Runtime.CompilerServices;
using UnityEngine;

public class coin : MonoBehaviour
{
    private float pontos;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            Debug.Log("colideo");
            pontos += 10;
}
    }

}
