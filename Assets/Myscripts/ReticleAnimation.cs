using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleAnimation : MonoBehaviour
{
    [SerializeField]
    float rotateSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // how do we do this again?

        // rotate the reticle
        //transform.localRotation = Quaternion.Euler(Vector3.up * Time.time * rotateSpeed);
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
