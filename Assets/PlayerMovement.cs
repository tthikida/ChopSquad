using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = 1f;
        }
        inputVector.Normalize();
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir * speed * Time.deltaTime;
        Debug.Log(inputVector);
    }
}
