using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // these variables change our movement speed
    //float xValue;
    //[SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 0.01f;
    //[SerializeField] float zValue = 0f;

    // Start is called before the first frame update
    // type whatever you like
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //xValue = Input.GetAxis("Horizontal");
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");

        //transform.Translate(xValue, yValue, zValue);
        transform.Translate(xValue, yValue, zValue);
    }
}
