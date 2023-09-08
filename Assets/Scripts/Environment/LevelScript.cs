using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour
{
    [SerializeField]
    GameObject[]  environment;
    [SerializeField]
    float Zpos = 12.5f;
    [SerializeField]
    bool creatingEnv = false;
    [SerializeField]
    int envNum = 0;

   
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if(creatingEnv == false)
        {
            creatingEnv = true;
            StartCoroutine(GenerateEnvironment());
        }
    }
    IEnumerator GenerateEnvironment()
    {
        envNum = Random.Range(0,environment.Length);
        Instantiate(environment[envNum], new Vector3(0,0,Zpos),Quaternion.identity);
        Zpos += 65;
        yield return new WaitForSeconds(12);
        creatingEnv = false;
    }
}
