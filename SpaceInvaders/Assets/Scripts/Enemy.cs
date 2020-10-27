using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.5f;
    float numMovements = 0;
    float speed = 0.25f;
    public GameObject enemyProjectile;
    public GameObject enemyProjectileClone;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.playGame)
        {
            enemyMove();
            enemyFire();
        }
    }

    void enemyMove()
    {
        timer += Time.deltaTime;
        if (timer > timeToMove && numMovements < 8)
        {
            transform.Translate(new Vector3(speed, 0, 0));
            timer = 0;
            numMovements++;
        }

        if (numMovements == 8)
        {
            transform.Translate(new Vector3(0, -0.5f, 0));
            numMovements = -1;
            speed = -speed;
        }
    }

    void enemyFire()
    {
        if(Random.Range(0, 500.0f) < 1)
        {
            enemyProjectileClone = Instantiate(enemyProjectile, new Vector3(enemy.transform.position.x, enemy.transform.position.y - 0.4f, 0), enemy.transform.rotation) as GameObject;
        }
    }
}
