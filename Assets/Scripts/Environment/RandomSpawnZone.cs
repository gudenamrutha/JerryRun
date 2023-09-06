using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnZone : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject[] objectsToSpawn;
    void Start()
    {
        for(int i=0; i < 5; i++)
        {
            int ind = Random.Range(0,objectsToSpawn.Length);
            Instantiate(objectsToSpawn[ind], new Vector3(0,0.5f, i*20), Quaternion.identity);
        }
    }

    
}
