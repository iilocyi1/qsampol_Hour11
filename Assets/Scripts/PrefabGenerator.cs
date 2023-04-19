using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 spawnValues;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Vector3 spawnposition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 0f, 0f);
           
            GameObject gameobject = Instantiate<GameObject>(prefab, spawnposition, transform.rotation);

        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
        
    }
}
