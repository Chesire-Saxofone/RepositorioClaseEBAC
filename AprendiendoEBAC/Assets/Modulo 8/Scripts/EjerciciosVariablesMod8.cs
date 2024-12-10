using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    int miEntero = 0;
    float miFloat = 1.3f;
    float primerFloat = 5;
    float segundoFloat = 6;
    int castExplicito;
    int cambioColor;
    public string colorPString= "";
    float floatAString = 2.4532f;
    string vienedelFloat;
    string miNombreCompleto = "Jose Felipe Ospina"; 
    char deli = ' ';
    string miNumeroString1 = "600";
    string miNumeroString2 = "66";
    int numero1;
    int numero2;
    string miOracion = "Las olas llevan nuestro barco";
    string oracionFinal = "Esta es la oracion Final"; 

    // Start is called before the first frame update
    void Start()
    {
        castExplicito = (int)(primerFloat + segundoFloat);
        Debug.Log(castExplicito);
        cambioColor = UnityEngine.Random.Range(1, 10);
        vienedelFloat = floatAString.ToString();
        Debug.Log(vienedelFloat);
        string miPrimerNombre = miNombreCompleto.Substring(0, 4);
        string miSegundoNombre = miNombreCompleto.Substring(5, 6);
        string miPrimerApellido = miNombreCompleto.Substring(12, 6);
        Debug.Log(miPrimerNombre + miSegundoNombre + miPrimerApellido);
        string[] nombres = miNombreCompleto.Split(deli);
        foreach (string palabras in nombres)
        {
            Debug.Log(palabras);
        }
        bool exito = int.TryParse(miNumeroString1, out numero1);
        bool exito2 = int.TryParse(miNumeroString2, out numero2);
        if (exito2 && exito)
        {
            int miSuma = numero1 + numero2;
            Debug.Log(miSuma);
        }
        else
        {
            Debug.Log("hubo un error");
        }
        for (int i = 0; i <= miOracion.Length; i++) { 
        if (i % 2 == 0)
            {
                Debug.Log(miOracion[i]);
            }
        }
        string variableFinal = oracionFinal.Substring(11,13);
        Debug.Log(variableFinal);
    }
    private void FixedUpdate()
    {
        miFloat *= 2;
        switch (colorPString)
        {
            case "verde":
                var meshrendermaterial = GetComponent<MeshRenderer>().material;
                Color c = Color.green;
                meshrendermaterial.color = c;
                break;
            case "gris":
                var meshrendermaterial2 = GetComponent<MeshRenderer>().material;
                Color c2 = Color.gray;
                meshrendermaterial2.color = c2;
                break;
            case "amarillo":
                var meshrendermaterial3 = GetComponent<MeshRenderer>().material;
                Color c3 = Color.yellow;
                meshrendermaterial3.color = c3;
                break;
            default:
                if (cambioColor % 2 == 0)
                {
                    var meshrendermaterial4 = GetComponent<MeshRenderer>().material;
                    Color c4 = Color.blue;
                    meshrendermaterial4.color = c4;
                }
                else
                {
                    var meshrendermaterial4 = GetComponent<MeshRenderer>().material;
                    Color c5 = Color.red;
                    meshrendermaterial4.color = c5;
                }
                 break;
        }
       
    
    }
}
