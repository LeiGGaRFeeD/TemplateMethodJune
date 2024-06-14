using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterContext : MonoBehaviour
{
    private IAttackStrategy _currentStrategy;
    private Animator _animator;
    private bool _isAttacking;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetStrategy(IAttackStrategy strategy)
    {
        _currentStrategy = strategy;
    }

    public void PerformAttack()
    {
        _isAttacking = true;
        _currentStrategy?.ExecuteAttack();
    }

    public bool IsAttacking()
    {
        return _isAttacking;
    }

    // Этот метод может быть вызван в конце анимации атаки для сброса состояния
    public void EndAttack()
    {
        _isAttacking = false;
    }
}
