using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tron3Controller : MonoBehaviour
{
    // Start is called before the first frame update
    private float direction = 1; 
    private float moveSpeed = 3;
    private void Update()
    {
        Vector3 movement = new Vector3(x: direction, y: 0f, z: 0f);
        transform.Translate(translation: movement * moveSpeed * Time.deltaTime);
        if (transform.position.x >= -4f || transform.position.x <= -0.2f)
        {
            direction *= -1;
        }
    }
}
