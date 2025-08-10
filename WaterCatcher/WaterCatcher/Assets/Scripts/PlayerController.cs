using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D _rb;
    [SerializeField] float _playerspeed = 10f;

    [SerializeField] WaterControl _watercontrol;


    float _inputHorizontal;
    void Start()
    {
     _rb = gameObject.GetComponent<Rigidbody2D>();
        _watercontrol.SpawnObject();
     
    }

    // Update is called once per frame
    void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");

        if (_inputHorizontal != 0)
        {
            _rb.AddForce (new Vector2(_inputHorizontal * _playerspeed, 0));
        }
    }
}
