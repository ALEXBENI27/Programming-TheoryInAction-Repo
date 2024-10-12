using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    private float horizontalInput;
    private float verticalInput;
    private float speed = 15.0f;
    private float rotateSpeed = 60.0f;
    [SerializeField] private float jumpForce = 50;
    
    private AudioSource playerAudio;
    [SerializeField] private AudioClip collectSound;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        PlayerMovement();
    }

    private void PlayerMovement() {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Time.deltaTime * Vector3.forward * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed * horizontalInput);

        if(Input.GetKeyDown(KeyCode.Space)) {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Collect")) {
            playerAudio.PlayOneShot(collectSound, 1.0f);
        }
    }
}
