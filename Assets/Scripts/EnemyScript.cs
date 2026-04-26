using System;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 lookDirection = (player.transform.position
        - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
        //destroi o inimigo caso ele caia do mapa:
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
