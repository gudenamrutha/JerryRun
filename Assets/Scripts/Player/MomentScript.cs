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
    public static bool canMove = false;
    [SerializeField]
    bool isJumping = false;
    [SerializeField]
    bool comingDown = false;
    [SerializeField]
    GameObject charModel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed, Space.World);
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
                }
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < rightSide)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
                }
            }
            if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space) ){
                if(isJumping == false)
                {
                    isJumping = true;
                    charModel.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(JumpSequence());
                }
            }
        }
        if(isJumping == true)
        {
            if(comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 8,Space.World);
            }
            if (comingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -8, Space.World);
            }
        }
    }
    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.75f);
        comingDown = true;
        yield return new WaitForSeconds(0.75f);
        isJumping = false;
        comingDown = false;
        charModel.GetComponent<Animator>().Play("Medium Run");
    }
}
