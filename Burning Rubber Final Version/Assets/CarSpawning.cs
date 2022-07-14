using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawning : MonoBehaviour
{
    public GameObject SportsCar1;
    public GameObject SportsCar2;
    public Transform SpawnPoint;
    void Start()
    {
        if(Savedscript.SportsCarID == 2)
        {
            Instantiate(SportsCar1 , SpawnPoint.position, SpawnPoint.rotation);
        }
        if (Savedscript.SportsCarID == 3)
        {
            Instantiate(SportsCar2, SpawnPoint.position, SpawnPoint.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
