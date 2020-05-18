﻿using System.Collections;
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

    public Image pasajero;

    public float timeLeft = 180f;

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

        timeLeft -= Time.deltaTime;
        segundos_restantes.text = timeLeft.ToString();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CambiarEscena("StartMenu");
            print("Tecla Escape presionada");
        }
    }

    private void CargarDatos(int n)
    {
        System.Random randomGen = new System.Random();
        int num = randomGen.Next(1,34);

        Debug.Log(num);
        pasajero.sprite = Resources.Load<Sprite>("Sprites/peep-"+ num.ToString());

        nombre.text = listaPasajeros[n][0];
        nacionalidad.text = listaPasajeros[n][1];
        viaja_a.text = listaPasajeros[n][2];
    }

    private void CambiarPersonaje()
    {
        int personaje = 2;
        Botones.passenger = personaje;
        CargarDatos(personaje);
    }

    public void CambiarEscena(string nombre)
    {
        print("Cambiando a la Escena " + nombre);
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {
        print("Saliendo del Juego");
        Application.Quit();
    }
}
