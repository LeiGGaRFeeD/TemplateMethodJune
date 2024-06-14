using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackType3 : IAttackStrategy
{
    private Animator _animator;

    public AttackType3(Animator animator)
    {
        _animator = animator;
    }

    public void ExecuteAttack()
    {
        _animator.SetTrigger("Attack3");
        Debug.Log("Executing Attack Type 3");
    }
}