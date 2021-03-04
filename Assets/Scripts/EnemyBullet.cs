using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float BulleteSpeed;
    private Vector3 _shootVector;
    private Rigidbody2D _rb;
    private void Start()
    {
     _rb=gameObject.GetComponent<Rigidbody2D>();
        _shootVector= GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyAttackController>().shootVector;
    }
    private void FixedUpdate()
    {
        _rb.velocity = _shootVector * BulleteSpeed;;
    }
private void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "Player" || Other.gameObject.layer == 10)
         {
            if (Other.gameObject.tag == "Player")
            {
                Other.gameObject.GetComponent<PlayerHealth>().RefuseHealth();
            }
            Destroy(gameObject);
        }
    }
}
