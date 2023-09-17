using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigSpawner : MonoBehaviour
{
    private float spawnSeconds;
    [SerializeField] private GameObject piggy;
    [SerializeField] private GameObject[] pigFarms;
    void Start()
    {
        StartCoroutine(SpawnPig());
        spawnSeconds = 5f;
    }

    IEnumerator SpawnPig(){
        GameObject area = pigFarms[Random.Range(0, 5)];
        Vector3 spawnLocate = new Vector3(area.transform.position.x + Random.Range(-2, 2), area.transform.position.y + 2, area.transform.position.z + Random.Range(-2, 2));
        
        yield return new WaitForSeconds(spawnSeconds);
        Instantiate(piggy, spawnLocate, area.transform.rotation);
        if(spawnSeconds < 1){
            spawnSeconds -= .1f;
        }
        StartCoroutine(SpawnPig());
            
    }

        
    
}
