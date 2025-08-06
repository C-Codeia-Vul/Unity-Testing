using UnityEngine;

public class FloorScroller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private float _floorScrollerSpeed = 2.0f;
    [SerializeField]
    private float _offScreenPosition = -8.112f;

    [SerializeField]
    private float _resetXposition = 8.34327f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _floorScrollerSpeed * Time.deltaTime); // this is not enough by itself. This makes the floor move to the left, but it does not make it appear again/
        if (_offScreenPosition > transform.position.x)
        {
            transform.position = new Vector3(_resetXposition, transform.position.y, transform.position.z);
        }
    }
}
