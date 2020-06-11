using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    public TextMeshProUGUI segundos_restantes;
    public TextMeshProUGUI pasajeros_restantes;
    public TextMeshProUGUI nombre;
    public TextMeshProUGUI nacionalidad;
    public TextMeshProUGUI viaja_a;

    public Image peep;
    private float timeLeft = 20f;

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
            segundos_restantes.text = (timeLeft).ToString("00.00");
        }
        else
        {
            GenerarPersonaje("Tiempo agotado");
            //Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CammbiarEscena();
        }
    }

    private void CargarDatos()
    {
        System.Random randomGen = new System.Random();
        int num = randomGen.Next(1,34);

        Debug.Log(num);
        peep.sprite = Resources.Load<Sprite>("Sprites/peep-"+ num.ToString());

        num = randomGen.Next(0, listaPasajeros.Count);
        nombre.text = listaPasajeros[num].Nombre;
        nacionalidad.text = listaPasajeros[num].Nacionalidad;
        viaja_a.text = listaPasajeros[num].Destino;
        paciente = num;
        Botones.Passenger = num;
    }

    public void CammbiarEscena()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void CammbiarEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }

    public void GenerarPersonaje(string nombre)
    {
        print("Desencadenante " + nombre);

        bool esPositivo = listaPasajeros[paciente].Covid;

        // Enviado a cuarentena con positivo a COVID OR Enviado a casa con negativo a !COVID
        if ((nombre.Equals("aislamiento") && esPositivo) || (nombre.Equals("dejar_ir") && !esPositivo))
        {
            print("Acierto");
            Resultados.sumarAcierto();
            //aciertos++;
        }
        else
        {
            print("Fallo");
            Resultados.sumarFallo();
            //fallos++;
        }

        print("¿era Positivo ?: " + esPositivo);

        Debug.Log("Aciertos: " + Resultados.obtenerAciertos() + "\t Fallos: " + Resultados.obtenerFallos() + "\n-------------------------------------------");
        pasajerosLeft--;

        if (pasajerosLeft > 0)
        {
            CammbiarEscena("Principal");
        } else
        {
            CammbiarEscena("Resultados");
        }

    }

    public void Salir()
    {
        print("Saliendo del Juego");
        Application.Quit();
    }
}
