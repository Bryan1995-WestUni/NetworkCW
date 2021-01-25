using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int MovementRate = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * MovementRate;
        var verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * MovementRate;

        transform.Translate(horizontalInput, verticalInput, 0);
    }
}
