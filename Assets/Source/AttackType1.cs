using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackType1 : IAttackStrategy
{
    private Animator _animator;

    public AttackType1(Animator animator)
    {
        _animator = animator;
    }

    public void ExecuteAttack()
    {
        _animator.SetTrigger("Attack1");
        Debug.Log("Executing Attack Type 1");
    }
}