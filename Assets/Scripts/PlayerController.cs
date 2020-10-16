using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float _forceMultipler;
    private float _moveHorizontal, _moveVertical;
    
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _moveHorizontal = Input.GetAxis("Horizontal") * _forceMultipler;
        _moveVertical = Input.GetAxis("Vertical") * _forceMultipler;

        _rigidbody.AddForce(_moveHorizontal, 0, _moveVertical);
        
        
    }
    private void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.CompareTag("Score"))
        {
            Destroy(other.gameObject);
            // Increase Score
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Score"))
        {
            Destroy(other.gameObject);
            // Increase Score
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Area"))
        {
            Debug.Log("Ouch!");
        }
    }

    private void Awake()
    {
        
    }
}
