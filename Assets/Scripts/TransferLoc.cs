using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using Random = UnityEngine.Random;

public class TransferLoc : MonoBehaviour
{
    public SpawnManager spawnManager;
    public GameObject Loc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("123");
            Loc.SetActive(true);
            spawnManager.CoutEnemy = Random.Range(1,5);
            //spawnManager.mesh = GetComponent<MeshCollider>();
            spawnManager.AllCout();
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Loc.SetActive(false);
        }
    }
}
