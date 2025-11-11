using UnityEngine;
public class Coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int point = 0;//crio a variael ponto
    public GameManager gamemanager;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))//comparo ela com o player
        {
            gamemanager.addpontos(10);
            Destroy(gameObject);
            playeraudio som = collision.GetComponent<playeraudio>();
            som.PlaySFX(som.coinssound);
        }
    }
}