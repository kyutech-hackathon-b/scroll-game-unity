using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public EnemyController[] enemies;

    void FindAllEnemiesInScene()
    {
        enemies = UnityEngine.Object.FindObjectsOfType<EnemyController>();
    }

    // Start is called before the first frame update
    void Awake()
    {
        FindAllEnemiesInScene();
    }

    public void PlayerDeath()
    {
        for (var i = 0; i < enemies.Length; i++)
        {   
            if(!enemies[i].control.enabled)
                enemies[i].PlayerDeath();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
