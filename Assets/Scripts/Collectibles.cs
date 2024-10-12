using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    private float rotationSpeed = 0.5f;
    
    [SerializeField] private GameObject onCollectEffect;
    private AudioSource playerAudio;
    [SerializeField] private AudioClip collectSound;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RotateCollectible();
    }

    private void RotateCollectible() {
        transform.Rotate(0,rotationSpeed, 0);
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
    }

}
