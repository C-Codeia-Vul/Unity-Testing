using System.Runtime.CompilerServices;
using Unity.Android.Gradle.Manifest;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
    
{
    [SerializeField]
    float _playerMS = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]
    float _jumpForce = 3f;

    private Rigidbody2D _rb;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0); // THIS IS AN ESSENTIAL CODE THAT i MUST NEVER FORGET
       _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementBreakdown();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.linearVelocity = Vector2.up * _jumpForce;
        }

    }

    private void movementBreakdown()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalinput, verticalinput, 0) * _playerMS * Time.deltaTime;
        transform.Translate(movement);
    }
}

