using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptesfera : MonoBehaviour
{
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
        var meshrendermaterial = GetComponent<MeshRenderer>().material;
        Color c = new Color(Random.value, Random.value, Random.value);
        meshrendermaterial.color = c;
    }
}
