using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCubo3 : MonoBehaviour
{
    public ScriptCubo scriptCubo;
    public ScriptCuboOr scriptCubo2;
    public bool cambioColor5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (scriptCubo.cambioColor3 == true || scriptCubo2.cambioColor4 == true)
        {
            cambioColor5 = false;
            var meshrendermaterial = GetComponent<MeshRenderer>().material;
            Color c = Color.white;
            meshrendermaterial.color = c;
        }
        else
        {
            cambioColor5 = true;
            var meshrendermaterial = GetComponent<MeshRenderer>().material;
            Color c = Color.black;
            meshrendermaterial.color = c;
        }
    }
}
