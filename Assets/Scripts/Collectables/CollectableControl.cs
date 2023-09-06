using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CollectableControl : MonoBehaviour
{
    public static int coinCount = 0;
    [SerializeField]
    GameObject coinCountToDisplay;
    [SerializeField]
    GameObject coinEndCountToDisplay;

    // Update is called once per frame
    void Update()
    {
        
        coinCountToDisplay.GetComponent<TextMeshProUGUI>().text = coinCount.ToString();
        coinEndCountToDisplay.GetComponent<TextMeshProUGUI>().text = coinCount.ToString();
    }
}
