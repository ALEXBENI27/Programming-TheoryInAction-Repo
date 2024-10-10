using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrhicleController : MonoBehaviour
{
    private float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(transform.position.z < 17) {
            Destroy(gameObject);
        } else if(transform.position.z > 115) {
            Destroy(gameObject);
        }
    }
}
