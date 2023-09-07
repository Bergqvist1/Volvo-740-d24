using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiendeHanterare : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prefab;
    public GameObject enemy;



    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy == null)
        {
            SpawnEnemy();
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        float x = Random.Range(-10f,10f);
        float z = Random.Range(-10f,10);
        Vector3 position = new Vector3(x,1f,z);

        enemy = Instantiate(prefab);
        enemy.transform.position = position;
    }
}
