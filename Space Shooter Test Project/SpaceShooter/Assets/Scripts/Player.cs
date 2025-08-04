using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // public or private refrence ->  _variable refers to a private variable
    // data type (int, string, bool , float) 
    // every variable has  a name.
    // optional: a value assigned 
    // attribute [SerializeField] to read or overwrite it in the inspector in Unity

    [SerializeField]
    private float _speed = 3.5f;
    [SerializeField]
    private GameObject _laserPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // take the current position and assing it as a new position as 0 for all axeses 
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Calculatemovement();


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_laserPrefab, transform.posistion, Quaternion.identity);
            Debug.Log("Space Key Pressed");
        }

    }

    void Calculatemovement()
    {
        // new vector 3(1,0,0)   . 1 = meter                  . Time.deltatime is real time.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * _speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime);

        // If player position on the Y is greater than 0
        // y position = 0 
        // esle if the position o nthe y is less than 3.8f, y position = -3.8f

        

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.8f, 0), 0);

        if (transform.position.x > 11)
        {
            transform.position = new Vector3(-11, transform.position.y, 0);
        }
        else if (transform.position.x <= -11)
        {
            transform.position = new Vector3(11, transform.position.y, 0);
        }
    }
}

