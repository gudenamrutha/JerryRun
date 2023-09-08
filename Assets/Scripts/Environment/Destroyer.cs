using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    string parentName;
    // Update is called once per frame
    void Update()
    {
        parentName = transform.name;
        StartCoroutine(DestroySection());
    }
    IEnumerator DestroySection()
    {
        yield return new WaitForSeconds(180);
        if(parentName == "Environment(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
