using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public int pontos = 0;
    public int vidas = 3;
    public TextMeshProUGUI textPontos;
    public TextMeshProUGUI textVida;

    public void addpontos(int qtd)
    {
        pontos += qtd;

        Debug.Log("pontos: " + pontos);
        if (pontos < 0)
        {

            pontos = 0;

        }
    }
    public void alteravida(int vida) 
    { 
        vidas -= vida;
        textVida.text = "Vidas: " + vidas;
        Debug.Log("Vidas: " + vidas);
        GameObject player = GameObject.FindWithTag ("Player" );
        player.GetComponent<Player>().ReiniciarPosicao();
        if (vidas <= 0)
        {
            Time.timeScale = 0;
            Destroy (player);
            Debug.Log("Morreu seu bostinha");
        }
    }
}
