using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UIElements;

public class ScriptArreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //primer ejercio
        int[] arreglo1 = new int[7];
        int[] arreglo2 = new int[7];
        for (int i = 0; i < arreglo1.Length; i++)
        { arreglo1[i] = i+1; }
        for (int j = 0;j < arreglo2.Length; j++)
            { arreglo2[j] = j+3; }
        int[] arreglo3 = new int[7];
        for (int i = 0;i < arreglo3.Length; i++)
            { arreglo3[i] = arreglo1[i] + arreglo2[i];
            Debug.Log(arreglo3[i]);
        }
        //segundo ejercicio
        string[] arregloOracion = new string[7] {"Hola","sean","bienvenidos","a","mi","nuevo","arreglo" };
        string oracionFinal = "";
        foreach (string oracion in arregloOracion)
        {
            oracionFinal = $"{oracionFinal} {oracion}";
        }
        Debug.Log(oracionFinal);
        //ejercicio final
        int[,] mimatriz1 = new int[2, 3] { {2,4,6 },{3,5,7 }};
        int[] mimatriz2 = new int[3] { 4, 5, 6 };
        int filas = mimatriz1.GetLength(0);
        int columnas = mimatriz1.GetLength(1);
        int[] resultado = new int[filas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i] += mimatriz1[i, j] * mimatriz2[j];
            }
        }
        for (int i = 0;i < resultado.Length; i++)
        {
            Debug.Log(resultado[i]);
        }


    }
 
    // Update is called once per frame
    void Update()
    {
        
    }
}
