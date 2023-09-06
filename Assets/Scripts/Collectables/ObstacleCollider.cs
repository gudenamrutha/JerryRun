using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollider : MonoBehaviour
{
    [SerializeField]
    GameObject thePlayer;
    [SerializeField]
    GameObject charModel;
    [SerializeField]
    AudioSource headHurt;
    [SerializeField]
    GameObject cam;
    [SerializeField]
    GameObject levelController;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<MomentScript>().enabled = false;
        levelController.GetComponent<LevelDistance>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        headHurt.Play();
        cam.GetComponent<Animator>().enabled = true;
        levelController.GetComponent<EndRunSequence>().enabled = true;
    }
}
