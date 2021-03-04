using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)//load game over meny and stop game tme when player died
    { 
     animator.transform.root.gameObject.GetComponent<PlayerHealth>().GameOver();
        Time.timeScale = 0f;
        Destroy(animator.transform.root.gameObject);
    }
}
