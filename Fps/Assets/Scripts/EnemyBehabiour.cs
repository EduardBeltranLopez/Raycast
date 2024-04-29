using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream
=======
using UnityEngine.AI;
>>>>>>> Stashed changes

public class EnemyBehabiour : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
<<<<<<< Updated upstream
    private GameObject orbe;
=======
    public Transform target;
>>>>>>> Stashed changes



    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
<<<<<<< Updated upstream
        orbe = GameObject.Find("Orbe");
=======
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        
=======
        target = GameObject.Find("Target").transform;
>>>>>>> Stashed changes
    }

    void EnemyGo()
    {
<<<<<<< Updated upstream
        Vector3 lookDirection = (orbe.transform.position - transform.position).normalized;
=======
        Vector3 lookDirection = (target.transform.position - transform.position).normalized;
>>>>>>> Stashed changes

        enemyRb.AddForce(lookDirection * speed);
    }
}
