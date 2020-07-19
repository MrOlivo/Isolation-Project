using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ControladorSQLite : MonoBehaviour
{
    string rutaDB;
    string strConexionDB;
    string DBFileName = "MOCK_DATA.db";

    IDbConnection dbConnection;
    IDbCommand dbCommand;
    IDataReader reader;

    public static List<ModelPasajero> objs = new List<ModelPasajero>(); 

    // Start is called before the first frame update

    public void OpenDB()
    {
        //crear y abrir la Conexión
        //Comprueba que plataforma es

        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor)
        {
            rutaDB = Application.dataPath + "/StreamingAssets/" + DBFileName;

        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            rutaDB = Application.dataPath + "/Raw/" + DBFileName;

        }
        //Si es Android
        else if (Application.platform == RuntimePlatform.Android)
        {
            rutaDB = Application.persistentDataPath + "/" + DBFileName;
            //comprobarsi el archivo se encentra en persistan data
            if (!File.Exists(rutaDB))
            {
                WWW loadDB = new WWW("jar:file://" + Application.dataPath + "!/assets/" + DBFileName);

                while (!loadDB.isDone)
                {

                }
                File.WriteAllBytes(rutaDB, loadDB.bytes);
            }

        }

        strConexionDB = "URI=file:" + rutaDB;
        dbConnection = new SqliteConnection(strConexionDB);
        dbConnection.Open();
    }

   public void CloseDB()
    {
        // cerrar las conexiones
        reader.Close();
        reader = null;
        dbCommand.Dispose();
        dbCommand = null;
        dbConnection.Close();
        dbConnection = null;
    }

   public void Read(string item, string table)
    {
        //Crear la consulta
        dbCommand = dbConnection.CreateCommand();
        string sqlQuery = "SELECT " + item + " FROM " + table;
        dbCommand.CommandText = sqlQuery;

        //Leer la base de datos
        reader = dbCommand.ExecuteReader();

        while (reader.Read())
        {

            try
            {
                ModelPasajero mp = new ModelPasajero();
                
                // id
                mp.Id = reader.GetInt32(0);
                
                // Nombre
                mp.Nombre = reader.GetString(1);
                
                // Nacionalidad 
                mp.Nacionalidad = reader.GetString(2);
                
                //Destino
                mp.Destino = reader.GetString(3);
                
                //Estancia
                mp.Estancia = reader.GetInt32(4);
                
                //Habitos
                mp.Habitos = reader.GetString(5);
                
                //Sintomas
                mp.Sintomas = reader.GetString(6);
                
                //Temperatura
                mp.Temperatura = reader.GetFloat(7);
                
                //Covid
                mp.Covid = bool.Parse(reader.GetString(8));

                objs.Add(mp);
            } 

            catch (FormatException fe)
            {
                Debug.Log("Error " + fe.Message);
                continue;
            }
            catch (Exception e)
            {
                Debug.Log("Error " + e.Message);
                continue;
            }

           
        }
        
    }





}
