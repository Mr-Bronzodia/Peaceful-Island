using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeLook : MonoBehaviour
{

    [SerializeField] private float _speed;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (transform.forward * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + (-transform.forward * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + (-transform.right * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + (transform.right * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = transform.position + (transform.up * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.position = transform.position + (-transform.up * _speed * Time.deltaTime);
        }
    }
}
