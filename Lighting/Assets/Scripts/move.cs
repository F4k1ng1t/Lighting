using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float vInput;
    public float hInput;
    public float moveSpeed = 5f;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        hInput = Input.GetAxis("Horizontal") * moveSpeed;
    }
    private void FixedUpdate()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.MovePosition(transform.position + (transform.forward * vInput + this.transform.right * hInput) * Time.fixedDeltaTime);
    }
}
