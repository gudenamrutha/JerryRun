using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    [SerializeField]
    GameObject countDown3;
    [SerializeField]
    GameObject countDown2;
    [SerializeField]
    GameObject countDown1;
    [SerializeField]
    GameObject countDownGo;
    [SerializeField]
    GameObject fadeIn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDown());
    }
    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(1.5f);
        countDown3.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        countDown2.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        countDown1.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        countDownGo.SetActive(true);
       
    }

   
}
