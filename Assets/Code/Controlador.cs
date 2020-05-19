using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    public static Text segundos_restantes;
    public Text pasajeros_restantes;
    public Text nombre;
    public Text nacionalidad;
    public Text viaja_a;

    public Image peep;

    public float timeLeft = 180;

    public Dictionary<int, ModelPasajero> listaPasajeros;

    // Start is called before the first frame update
    void Start()
    {
        //peep = GameObject.Find("peep").GetComponent<Image>();
        nombre = GameObject.Find("txt_nombre").GetComponent<Text>();
        nacionalidad = GameObject.Find("txt_nacionalidad").GetComponent<Text>();
        viaja_a = GameObject.Find("txt_viaja_a").GetComponent<Text>();

        Pasajero p = gameObject.AddComponent<Pasajero>();
        listaPasajeros = p.Pasajeros;

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
            Application.Quit();
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
        int num = randomGen.Next(1,3);

        Debug.Log(num);
        peep.sprite = Resources.Load<Sprite>("Sprites/peep-"+ num.ToString());

        num = 0;
        nombre.text = listaPasajeros[num].Nombre;
        nacionalidad.text = listaPasajeros[num].Nacionalidad;
        viaja_a.text = listaPasajeros[num].Viaja_a;
    }

    public void CambiarEscena(string nombre)
    {
        print("Cambiando a la Escena " + nombre);
        Debug.Log("Cambiando a la Escena " + nombre);
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {
        print("Saliendo del Juego");
        Application.Quit();
    }
}
