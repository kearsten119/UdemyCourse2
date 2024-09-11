using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Add moveSpeed to the Inspector
    [SerializeField] float moveSpeed = 7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // (Get the Axis the players pushing) * (Make it frame rate independent) * (Good speed the player can move at)
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue,0,zValue);
    }
}
