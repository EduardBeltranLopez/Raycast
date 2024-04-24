using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehabiour : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject orbe;



    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        orbe = GameObject.Find("Orbe");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnemyGo()
    {
        Vector3 lookDirection = (orbe.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);
    }
}
