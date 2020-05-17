using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    private Text estancia;
    private Text habitos;
    private Text sintomas;
    private Text temperatura;
    private Text segundos_restantes;
    private Text pasajeros_restantes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CambiarEscena("StartMenu");
            print("Tecla Escape presionada");
        }
    }

    public void CambiarEscena(string nombre)
    {
        print("Cambiando a la Escena " + nombre);
        SceneManager.LoadScene(nombre);
    }

    public void CambiarPersonaje()
    {

    }

    public void CambiarTexto(Text txtElement)
    {
        txtElement.text = "Hola Unity";
    }

    public void Salir()
    {
        print("Saliendo del Juego");
        Application.Quit();
    }

    public void CargarDatos()
    {

    }
}
