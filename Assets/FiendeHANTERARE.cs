using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiendeSTRÖG : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prefab;
    public GameObject fiende;



    void Start()
    {
        fiende = GameObject.FindGameObjectWithTag("Fiende");
    }

    // Update is called once per frame
    void Update()
    {
        if(fiende == null)
        {
            SpawnFiende();
            SpawnFiende();
        }
    }

    private void SpawnFiende()
    {
        float x = Random.Range(-10f,10f);
        float z = Random.Range(-10f,10);
        Vector3 position = new Vector3(x,1f,z);

        fiende = Instantiate(prefab);
        fiende.transform.position = position;
    }
}
