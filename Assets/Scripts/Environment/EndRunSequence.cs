using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunSequence : MonoBehaviour
{
    [SerializeField]
    GameObject liveCoins;
    [SerializeField]
    GameObject liveDis;
    [SerializeField]
    GameObject gameOver;
    [SerializeField]
    GameObject fadeOut;
    void Start()
    {
        StartCoroutine(EndScreen());
    }
    IEnumerator EndScreen()
    {
        yield return new WaitForSeconds(5);
        liveCoins.SetActive(false);
        liveDis.SetActive(false);
        gameOver.SetActive(true);
        yield return new WaitForSeconds(5);
        fadeOut.SetActive(true);
    }
}
