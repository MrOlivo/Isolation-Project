using System;
public class ModelPasajero
{
    public string Nombre { get; set; }
    public string Nacionalidad { get; set; }
    public string Viaja_a { get; set; }
    public string Estancia { get; set; }
    public string Habitos { get; set; }
    public string Sintomas { get; set; }
    public int Temperatura { get; set; }
    public bool Covid { get; set; }

    public ModelPasajero(string nombre, string nacionalidad, string viaja_a, string estancia, string habitos, string sintomas, int temperatura, bool covid)
    {
        Nombre = nombre;
        Nacionalidad = nacionalidad;
        Viaja_a = viaja_a;
        Estancia = estancia;
        Habitos = habitos;
        Sintomas = sintomas;
        Temperatura = temperatura;
        Covid = covid;
    }
}
