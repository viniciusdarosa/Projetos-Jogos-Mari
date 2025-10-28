using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void play()
    {
        SceneManager.LoadScene(1);
    }
    public void activeconfig(GameObject go) 
    {
        go.SetActive(true); 
    }
    public void desactiveconfig(GameObject go)
    {
        go.SetActive(false);
    }
    public void activepause(GameObject go)
    {
        Time.timeScale = 0;
        go.SetActive(true);
    }
    public void desactivepause(GameObject go)
    {
        Time.timeScale = 1;
        go.SetActive(false);
    }
    public void voltarmenu(GameObject go)
    {
        SceneManager.LoadScene(0);
    }
}
