using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public float speed = 10.0f;
    [SerializeField]
    public float rotationSpeed = 10.0f;
    [SerializeField]
    public float gravity = 10.0f;
    private bool isGrounded = false;
    Vector3 targetTranslation;
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        float zTranslation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float xTranslation = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yTranslation =- gravity * Time.deltaTime;
        targetTranslation.x = xTranslation;
        targetTranslation.y = yTranslation;
        targetTranslation.z = zTranslation;
        gameObject.GetComponent<CharacterController>().Move(targetTranslation);
    }

}