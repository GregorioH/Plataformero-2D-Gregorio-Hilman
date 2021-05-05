using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public void Reintentar()
    {
        SceneManager.LoadScene("Juego");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Agua")
        {
            SceneManager.LoadScene("Derrota");
        } else 
        if (collision.gameObject.tag == "Meta")
        {
            SceneManager.LoadScene("Victoria");
        }
    }
}
