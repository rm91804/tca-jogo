
using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class CameraFollow : MonoBehaviour { public GameObject target;

void Start()
{

}

void Update() 
{
    transform.position = new Vector3(target.transform.position.x, transform.position.y, -10);
}
}