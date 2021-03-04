using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int scoreToAdd;
    [SerializeField] private int Health;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource DeathAudio;
    public Vector3 shootVector = new Vector3(0, -1, 0);
    private void RefuseHealth()//metode to take away Health
    {
        Health--;
        if (Health <= 0)
        {
            GameObject.Find("Player").GetComponent<PlayerHealth>().AddScore(scoreToAdd);
            animator.SetTrigger("Dead");
            DeathAudio.Play();
        }
    }
    void Start()
    {
         animator= gameObject.GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "Player" || Other.gameObject.layer == 8)
        {
            if (Other.gameObject.GetComponent<PlayerHealth>() != null)
            {
                Other.gameObject.GetComponent<PlayerHealth>().RefuseHealth();//refuse player health
            }
            RefuseHealth();
        }
        }
}
