using UnityEngine;
public class PlayerDead : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    { 
     animator.transform.root.gameObject.GetComponent<PlayerHealth>().GameOver();
        Time.timeScale = 0f;
        Destroy(animator.transform.root.gameObject);
    }
}
