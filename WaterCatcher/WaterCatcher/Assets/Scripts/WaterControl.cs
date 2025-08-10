using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterControl : MonoBehaviour
{
    [SerializeField] GameObject preFab;

    bool _gameOver = false;


    public void SpawnObject()

    {
        Instantiate(preFab, new Vector3(Random.Range(-8f, 8f), 6f, 0),Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !_gameOver)
        {
            SpawnObject();
            Destroy(preFab);
        } else if( collision.gameObject.tag == "Ground") 
        { _gameOver = true;
            Debug.Log("Game over");        
        
        } 
            
    }   
} 

