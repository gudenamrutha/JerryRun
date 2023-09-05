using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField]
    AudioSource coinFX;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        coinFX.Play();
        CollectableControl.coinCount++;
        this.gameObject.SetActive(false);
    }
}
