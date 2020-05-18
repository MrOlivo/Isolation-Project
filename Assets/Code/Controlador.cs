using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    public Text segundos_restantes;
    public Text pasajeros_restantes;
    public static Text nombre;
    public static Text nacionalidad;
    public static Text viaja_a;

    public static Image peep;

    public float timeLeft = 180;

    int diag_acertados;
    int diag_fallidos;

    public static int pda = 0;

    public static Dictionary<int, string[]> listaPasajeros;

    // Start is called before the first frame update
    void Start()
    {
        peep = GameObject.Find("peep").GetComponent<Image>();
        nombre = GameObject.Find("txt_nombre").GetComponent<Text>();
        nacionalidad = GameObject.Find("txt_nacionalidad").GetComponent<Text>();
        viaja_a = GameObject.Find("txt_viaja_a").GetComponent<Text>();

        Pasajero pas = gameObject.AddComponent<Pasajero>();
        listaPasajeros = pas.GetListaPasajeros();

        CambiarPersonaje(pda);
    }

    // Update is called once per frame
    void Update()
    {

        timeLeft -= Time.deltaTime;
        if (timeLeft > 0.0)
        {
            segundos_restantes.text = ((int)timeLeft).ToString();
        }
        else
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CambiarEscena("StartMenu");
            print("Tecla Escape presionada");
        }
    }


    private void CambiarPersonaje(int personaje)
    {
        Botones.passenger = personaje;
        CargarDatos(personaje);
    }

    public void CambiarPersonaje(string diagnostico)
    {
        if (diagnostico.Equals("isolation") && listaPasajeros[2][7].Equals("Si"))
        {
            diag_acertados++;
        }
        else if (diagnostico.Equals("isolation") && listaPasajeros[2][7].Equals("No"))
        {
            diag_fallidos++;
        }
        else if (diagnostico.Equals("let go") && listaPasajeros[2][7].Equals("Si"))
        {
            diag_fallidos++;
        }
        else if (diagnostico.Equals("let go") && listaPasajeros[3][7].Equals("No"))
        {
            diag_acertados++;
        }

        CambiarEscena("Main");
    }

    private void CargarDatos(int n)
    {
        System.Random randomGen = new System.Random();
        int num = randomGen.Next(1,34);

        Debug.Log(num);
        peep.sprite = Resources.Load<Sprite>("Sprites/peep-"+ num.ToString());

        nombre.text = listaPasajeros[n][0];
        nacionalidad.text = listaPasajeros[n][1];
        viaja_a.text = listaPasajeros[n][2];
    }

    public void CambiarEscena(string nombre)
    {
        print("Cambiando a la Escena " + nombre);
        Debug.Log("Cambiando a la Escena " + nombre);
        pda++;
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {
        print("Saliendo del Juego");
        Application.Quit();
    }
}
