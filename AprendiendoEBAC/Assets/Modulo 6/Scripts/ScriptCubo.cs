using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCubo : MonoBehaviour
{
    public Scriptesfera scriptesfera;
    public ScriptCapsula scriptcapsula;
    public bool cambioColor3;
    private void Awake()
    {
        //var meshrendermaterial = GetComponent<MeshRenderer>().material;
        //Color c = new Color(Random.value, Random.value,Random.value);
        //meshrendermaterial.color = c;
    }
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
        if (scriptesfera.CambioColor == true && scriptcapsula.CambioColor2 == true)
        {
            cambioColor3 = false;
            var meshrendermaterial = GetComponent<MeshRenderer>().material;
            Color c = Color.white;
            meshrendermaterial.color = c;
        }
        else
        {
            cambioColor3 = true;
            var meshrendermaterial = GetComponent<MeshRenderer>().material;
            Color c = Color.black;
            meshrendermaterial.color = c;
        }
    }
}
