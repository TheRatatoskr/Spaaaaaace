using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementMapper : MonoBehaviour
{

    [SerializeField] private Transform _mapperLocation;



    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_mapperLocation.position.x, transform.position.y, _mapperLocation.position.z);
    }
}
