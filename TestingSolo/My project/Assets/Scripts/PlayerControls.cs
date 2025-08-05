using Unity.Android.Gradle.Manifest;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
    
{
    [SerializeField]
    float _playerMS = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

      void Start()
    {
        transform.position = new Vector3(0, 0, 0); // THIS IS AN ESSENTIAL CODE THAT i MUST NEVER FORGET
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalinput, verticalinput, 0) * _playerMS * Time.deltaTime;
        transform.Translate(movement);
    }
}
