using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomentScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float movementSpeed = 3.0f;
    [SerializeField]
    float leftSide;
    [SerializeField]
    float rightSide;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed, Space.World);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
            }
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            if (this.gameObject.transform.position.x < rightSide)
            {
                transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
            }
        }
    }
}
