using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class VehicleSpawner : MonoBehaviour
{

    [SerializeField] private GameObject[] vehicles;
    private Vector3 spawnPos;
    private Vector3 spawnPos_B;
    private float positionAxisX = 3;
    private float positionAxisY = 0.6f;
    private float positionAxisZ = 25f;
    private float positionAxisX_B = -7;
    private float positionAxisZ_B = 109;
    private float timeDelay = 3;
    private float timeRepeat = 3;
    private float rot = 180;
    private int vehiclesLength;

    // Start is called before the first frame update
    void Start()
    {
        vehiclesLength = vehicles.Length;

        InvokeRepeating("SpawnVehicles", timeDelay, timeRepeat);
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void SpawnVehicles() {
        Vector3 spawnPos = new(positionAxisX, positionAxisY, positionAxisZ); 
        Vector3 spawnPos_B = new(positionAxisX_B, positionAxisY, positionAxisZ_B);
        int randomVehicle = Random.Range(0, vehiclesLength);
        int randomPos = Random.Range(0, 2);

        if(randomPos == 1) {
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
            Instantiate(vehicles[randomVehicle], spawnPos, spawnRotation);
        } else {
            Quaternion spawnRotation_B = Quaternion.Euler(0, rot, 0);
            Instantiate(vehicles[randomVehicle], spawnPos_B, spawnRotation_B);
        }
        
    }

}
