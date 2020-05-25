using System;

[Serializable]
public class ModelPasajero
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Nacionalidad { get; set; }
    public string Destino { get; set; }
    public int Estancia { get; set; }
    public string Habitos { get; set; }
    public string Sintomas { get; set; }
    public float Temperatura { get; set; }
    public bool Covid { get; set; }

    public ModelPasajero()
    {

    }

    public ModelPasajero(int id, string nombre, string nacionalidad, string destino, int estancia, string habitos, string sintomas, float temperatura, bool covid)
    {
        Id = id;
        Nombre = nombre;
        Nacionalidad = nacionalidad;
        Destino = destino;
        Estancia = estancia;
        Habitos = habitos;
        Sintomas = sintomas;
        Temperatura = temperatura;
        Covid = covid;
    }
}
