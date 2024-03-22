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
        Vector3 movement = new Vector3(x: 0f, y: direction, z: 0f);
        transform.Translate(translation: movement * moveSpeed * Time.deltaTime);
        if (transform.position.y >= 4.17f || transform.position.y <= 0.8f)
        {
            direction *= -1;
        }
    }
}
