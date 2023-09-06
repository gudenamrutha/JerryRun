using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelDistance : MonoBehaviour
{
    [SerializeField]
    GameObject distanceToDisplay;
    [SerializeField]
    GameObject distanceEndToDisplay;
    [SerializeField]
    bool addingDistance = false;
    public int disRun = 0;
    [SerializeField]
    float disDelay = 0.35f;

    // Update is called once per frame
    void Update()
    {
        if (addingDistance == false)
        {
            addingDistance = true;
            StartCoroutine(AddingDistance());
        }
    }
    IEnumerator AddingDistance()
    {
        disRun++;
        distanceToDisplay.GetComponent<TextMeshProUGUI>().text = disRun.ToString();
        distanceEndToDisplay.GetComponent<TextMeshProUGUI>().text = disRun.ToString();
        yield return new WaitForSeconds(disDelay);
        addingDistance = false;
    }
}
