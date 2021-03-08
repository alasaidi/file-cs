using UnityEngine;
using System.Collections;

public class IdleState : StateMachineBehaviour {
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetFloat("IdleIndex", Random.value);
    }
}
