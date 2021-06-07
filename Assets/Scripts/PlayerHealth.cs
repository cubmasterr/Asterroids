using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject GameOverCanvas, UiCanvas, Score;
    [SerializeField] private GameObject[] Health;
    [SerializeField] private AudioSource DeathAudio;
    private int _score = 0;
    private int _health = 3;
    private Text scoreText;
    public void AddScore(int value)
     {
        _score += value;
        }
    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        UiCanvas.SetActive(false);
    }
    private void Start()
    {
  scoreText=Score.GetComponent<Text>();
        for (int i = 0; i < _health; i++)
        {
            Health[i].SetActive(true);
        }
    }
    public void RefuseHealth()
    {
        _health--;
        if (_health >= 0)
        {
            Health[_health].SetActive(false);
        }
        if (_health <= 0)
        {
            DeathAudio.Play();
            gameObject.GetComponent<Animator>().SetTrigger("Dead");
        }
    }
    void Update()
    {
        scoreText.text==_score.ToString();
        Score.GetComponent<Text>().text =_score.ToString();
    }
}
