using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboOnD : MonoBehaviour
{
    public GameObject CuboPrefaab;
    public List<GameObject> ListadeCubos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDisable()
    {
        if (ListadeCubos.Count < 1)
        {
            GameObject cubos = Instantiate(CuboPrefaab);
            cubos.transform.position = new Vector3(1, 3, -4);


            var meshrendermaterial = cubos.GetComponent<MeshRenderer>().material;
            Color c = new Color(Random.value, Random.value, Random.value);
            meshrendermaterial.color = c;


            ListadeCubos.Add(cubos);
        }
    }
}
