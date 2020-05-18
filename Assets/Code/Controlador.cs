using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    public Text estancia;
    public Text habitos;
    public Text sintomas;
    public Text temperatura;
    public Text segundos_restantes;
    public Text pasajeros_restantes;
    public Text nombre;
    public Text nacionalidad;
    public Text viaja_a;
    public Dictionary<int, string[]> listaPasajeros;

    private int pass = 3;

    // Start is called before the first frame update
    void Start()
    {
        Pasajero pasajero = gameObject.AddComponent<Pasajero>();
        listaPasajeros = pasajero.GetListaPasajeros();

        CargarDatos();
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
        CargarDatos();

        string nombre = txtElement.name;

        if (nombre.Equals("stay"))
        {
            estancia.text += listaPasajeros[pass][3];
        }
        else if (nombre.Equals("habits"))
        {
            habitos.text += listaPasajeros[pass][4];
        }
        else if (nombre.Equals("symptoms"))
        {
            sintomas.text += listaPasajeros[pass][5];
        }
        else if (nombre.Equals("temperature"))
        {
            temperatura.text += listaPasajeros[pass][6] + " º Celsius";
        }
    }


    public void CargarDatos()
    {
        nombre.text = listaPasajeros[pass][0];
        nacionalidad.text = listaPasajeros[pass][1];
        viaja_a.text = listaPasajeros[pass][2];
    }

    public void Salir()
    {
        print("Saliendo del Juego");
        Application.Quit();
    }
}
