using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Cinemachine;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject[] enemyOnMap;
    public Transform Loc;
    public Vector3 SpawnPos;
    private Collider mesh;
    public int CoutEnemy;
    public Vector3[] AllSpawnPos;

    private bool check;
    // Start is called before the first frame update
    void Start()
    {
        CoutEnemy = Random.Range(1,5);
        mesh = GetComponent<MeshCollider>();
        spawnpos();
        AllCout();
    }

    // Update is called once per frame
    void Update()
    {
        spawnEnemy(); 
    }

    void spawnEnemy()
    {
        enemyOnMap = GameObject.FindGameObjectsWithTag("Enemy");
        for (int b = 0; b <= AllSpawnPos.Length; b++)
        {
            if (enemyOnMap.Length < CoutEnemy) {
                int enemyIndex = Random.Range(0, enemyPrefabs.Length);
                Instantiate(enemyPrefabs[enemyIndex], AllSpawnPos[b], enemyPrefabs[enemyIndex].transform.rotation).transform.SetParent(Loc);
            }
        }
        

    }

    void spawnpos()
    {
        SpawnPos = new Vector3(Random.Range(mesh.bounds.min.x + 20, mesh.bounds.max.x - 20), 5, Random.Range(mesh.bounds.min.z + 20, mesh.bounds.max.z - 20));
    }

    public void AllCout()
    {
        check = false;
        AllSpawnPos = new Vector3[CoutEnemy];
        for (int i = 0; i <= CoutEnemy; i++)
        {
            AllSpawnPos[i] = SpawnPos;
            for (int g = 0; g <= i; g++)
            {
                if (AllSpawnPos[g] == SpawnPos || (AllSpawnPos[g].x - SpawnPos.x == 0 && AllSpawnPos[g].z - SpawnPos.z == 0))
                {
                    spawnpos();
                }
            }
            
        }
    }
}
