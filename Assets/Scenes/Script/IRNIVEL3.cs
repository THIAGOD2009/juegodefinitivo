using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class IRNIVEL3 : MonoBehaviour
{
    [Header("Sonido del botón")]
    public AudioSource sonidoBoton;

    public void IrANivel3()
    {
        StartCoroutine(ReproducirSonidoYCambiarEscena());
    }

    IEnumerator ReproducirSonidoYCambiarEscena()
    {
        if (sonidoBoton != null && sonidoBoton.clip != null)
        {
            sonidoBoton.Play();
            yield return new WaitForSecondsRealtime(sonidoBoton.clip.length);
        }

        SceneManager.LoadScene("Nivel3");
    }
}