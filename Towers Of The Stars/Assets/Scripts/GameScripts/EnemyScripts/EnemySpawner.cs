using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //make an array for the enemies
    public GameObject enemyA;
    public GameObject[] enemies;
    public float delay;
    public float timeBetweenDelay = 3;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(SpawnDelay());
    }

    // Update is called once per frame
    void Update()
    {
        timeBetweenDelay -= Time.deltaTime; //checks how much time passed
        if (timeBetweenDelay <= 0) // checks if timer is up
        {
            if (GlobalData.PlayerPoint <= 50)
            {
                timeBetweenDelay = 3; // resets timer
            }
            if(GlobalData.PlayerPoint > 50 && GlobalData.PlayerPoint <= 100) 
            {
                timeBetweenDelay = 2;
            }
            if(GlobalData.PlayerPoint > 100)
            {
                timeBetweenDelay = 1.5f;
            }

            
            StartCoroutine(SpawnDelay(enemyA)); // starts spawn 
            
        }
    }
    private IEnumerator SpawnDelay(GameObject enemy)
    {
        yield return new WaitForSeconds(delay); // wait for [delay] seconds
        Instantiate(enemy, transform.position, Quaternion.identity); // spawn enemy
    }
}
