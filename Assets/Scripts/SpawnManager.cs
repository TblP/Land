using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Cinemachine;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject[] enemyOnMap;
    public Transform Loc;
    private Vector3 SpawnPos;
    private Collider mesh;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnEnemy(); 
    }
    void spawnEnemy()
    {
        enemyOnMap = GameObject.FindGameObjectsWithTag("Enemy");
        SpawnPos = new Vector3(Random.Range(mesh.bounds.min.x, mesh.bounds.max.x), 5, Random.Range(mesh.bounds.min.z, mesh.bounds.max.z));
        if (enemyOnMap.Length <= 5)
        {
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);
            Instantiate(enemyPrefabs[enemyIndex], SpawnPos, enemyPrefabs[enemyIndex].transform.rotation).transform.SetParent(Loc);
        } 
    }
}
