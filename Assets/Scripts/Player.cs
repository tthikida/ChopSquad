using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private bool isWalking;

    GameInput gameInput;


    private void Awake()
    {
        gameInput = GetComponent<GameInput>();
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = gameInput.GetMovementVector();

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir * speed * Time.deltaTime;

        isWalking = moveDir != Vector3.zero;

        float rotationSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, rotationSpeed * Time.deltaTime);
    }

    public bool IsWalking()
    {
        return isWalking;
    }
}
