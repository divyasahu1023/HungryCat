using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
 
    void Update()
    {
        transform.Translate(Vector3.back*Time.deltaTime * speed);
    }
}
