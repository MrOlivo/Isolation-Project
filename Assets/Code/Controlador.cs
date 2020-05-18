using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    public Text segundos_restantes;
    public Text pasajeros_restantes;
    public Text nombre;
    public Text nacionalidad;
    public Text viaja_a;
    public Dictionary<int, string[]> listaPasajeros;

    // Start is called before the first frame update
    void Start()
    {
        Pasajero pasajero = gameObject.AddComponent<Pasajero>();
        listaPasajeros = pasajero.GetListaPasajeros();

        CambiarPersonaje();
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

    private void CambiarPersonaje()
    {
        int personaje = 2;
        Botones.passenger = personaje;
        CargarDatos(personaje);
    }

    private void CargarDatos(int n)
    {
        nombre.text = listaPasajeros[n][0];
        nacionalidad.text = listaPasajeros[n][1];
        viaja_a.text = listaPasajeros[n][2];
    }

    public void Salir()
    {
        print("Saliendo del Juego");
        Application.Quit();
    }
}
