using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Asteroids : MonoBehaviour
{
    [SerializeField] private GameObject SmallerAsteroid;
    [SerializeField] private float AsteroidSpeed;
    [SerializeField] private bool Islast;
    [SerializeField] private int scoreToAdd;
    [SerializeField] AudioSource deathAudio;
    private Animator animator;
    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        Vector3 randomVecror= new Vector3(0f, 0f, UnityEngine.Random.Range(0f, 360f));//rondomaise rotation of Asteroid's
        transform.Rotate(randomVecror);
    }
    void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "Player" || Other.gameObject.layer == 8)
        {
            if(Other.gameObject.GetComponent<PlayerHealth> ()!=null)
            {
                Other.gameObject.GetComponent<PlayerHealth>().RefuseHealth();//Refuse 1 health from player
                
            }
                if (!Islast && Other.gameObject.layer != 10)//check Is aible to spaun Asteroid's
                {
                 SpaunAsteroids();
                }
            GameObject.Find("Player").GetComponent<PlayerHealth>().AddScore(scoreToAdd);//Add player score for distroyed asteroid
            animator.SetTrigger("Dead");
            deathAudio.Play();
        }
        }
    private void SpaunAsteroids()//Spaun two new smal asteroid's
    {
        Instantiate(SmallerAsteroid, gameObject.transform.position, Quaternion.identity);
        Instantiate(SmallerAsteroid, gameObject.transform.position + Vector3.one, Quaternion.identity);
    }
    private void FixedUpdate()
    {
        if (gameObject.transform.position.y<=-20|| gameObject.transform.position.y >= 20)//Check distanse to destroy asteroids
        {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.x <= -20 || gameObject.transform.position.x >= 20)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.up * AsteroidSpeed * Time.fixedDeltaTime);
    }
}
