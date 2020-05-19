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

    public Image peep;

    public float timeLeft = 20;
    public static int pasajerosLeft = 20;

    private static int paciente;

    private static Dictionary<int, ModelPasajero> listaPasajeros;

    // Start is called before the first frame update
    void Start()
    {
        Pasajero p = gameObject.AddComponent<Pasajero>();
        listaPasajeros = p.Pasajeros;

        pasajeros_restantes.text = pasajerosLeft.ToString();

        CargarDatos();
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
            CambiarEscena("Tiempo agotado");
            //Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CambiarEscena("StartMenu");
            print("Tecla Escape presionada");
        }
    }

    private void CargarDatos()
    {
        System.Random randomGen = new System.Random();
        int num = randomGen.Next(1,34);

        Debug.Log(num);
        peep.sprite = Resources.Load<Sprite>("Sprites/peep-"+ num.ToString());

        num = randomGen.Next(0, 3);
        nombre.text = listaPasajeros[num].Nombre;
        nacionalidad.text = listaPasajeros[num].Nacionalidad;
        viaja_a.text = listaPasajeros[num].Viaja_a;
        paciente = num;
        Botones.passenger = num;
    }

    public void CambiarEscena(string nombre)
    {
        //print("Desencadenante " + nombre);
        Debug.Log("Desencadenante " + nombre);

        // Enviado a cuarentena con positivo a COVID OR Enviado a casa con negativo a !COVID
        if ((nombre.Equals("isolation") && listaPasajeros[paciente].Covid) || (nombre.Equals("let_go") && !listaPasajeros[paciente].Covid))
        {
            Debug.Log("Acierto");
        }
        else
        {
            Debug.Log("Fallo");
        }

        pasajerosLeft--;

        SceneManager.LoadScene("Main");
    }

    public void Salir()
    {
        print("Saliendo del Juego");
        Application.Quit();
    }
}
