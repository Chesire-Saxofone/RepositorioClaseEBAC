using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCuboOr : MonoBehaviour
{
    public Scriptesfera scriptesfera;
    public ScriptCapsula scriptcapsula;
    public bool cambioColor4;
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
        if (scriptesfera.CambioColor == true || scriptcapsula.CambioColor2 == true)
        {
            cambioColor4 = false;
            var meshrendermaterial = GetComponent<MeshRenderer>().material;
            Color c = Color.white;
            meshrendermaterial.color = c;
        }
        else
        {
            cambioColor4 = true;
            var meshrendermaterial = GetComponent<MeshRenderer>().material;
            Color c = Color.black;
            meshrendermaterial.color = c;
        }
    }
}
