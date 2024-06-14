using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackType2 : IAttackStrategy
{
    private Animator _animator;

    public AttackType2(Animator animator)
    {
        _animator = animator;
    }

    public void ExecuteAttack()
    {
        _animator.SetTrigger("Attack2");
        Debug.Log("Executing Attack Type 2");
    }
}