using UnityEngine;
public class DeadAnimationEnded : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       Destroy(animator.transform.root.gameObject);
    }
}
