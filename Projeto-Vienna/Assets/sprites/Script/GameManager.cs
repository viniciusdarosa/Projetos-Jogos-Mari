using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pontos = 0;
    public int vidas = 3;
    
    public void addpontos(int qtd/*quantidade*/) 
    {
        pontos += qtd;
        if (pontos < 0) { pontos = 0; }
        Debug.Log("pontos: " + pontos);
    }
    public void alteravida(int vida) 
    { 
        vidas -= vida;
        Debug.Log("Vidas: " + vidas);
        GameObject player = GameObject.FindWithTag ("Player" );
        player.GetComponent<Player>().ReiniciarPosição();
        if (vidas <= 0)
        {
            Time.timeScale = 0;
            Destroy (player);
            Debug.Log("Morreu seu bostinha");
        }
    }
}
