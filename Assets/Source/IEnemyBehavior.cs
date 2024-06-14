using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyBehavior
{
    void OnAppear();
    void OnDisappear();
    void UpdateBehavior();
}

// Enemy1Behavior.cs
public class Enemy1Behavior : MonoBehaviour, IEnemyBehavior
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void OnAppear()
    {
        _animator.SetTrigger("Attack");
    }

    public void OnDisappear()
    {
        // Остановка анимаций или другие действия
    }

    public void UpdateBehavior()
    {
        // Ничего не делаем
    }
}

// Enemy2Behavior.cs
public class Enemy2Behavior : MonoBehaviour, IEnemyBehavior
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void OnAppear()
    {
        // Ничего не делаем
    }

    public void OnDisappear()
    {
        // Остановка анимаций или другие действия
    }

    public void UpdateBehavior()
    {
        _animator.SetTrigger("Attack");
    }
}

// Enemy3Behavior.cs
public class Enemy3Behavior : MonoBehaviour, IEnemyBehavior
{
    private Animator _animator;
    private CharacterContext _playerContext;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerContext = FindObjectOfType<CharacterContext>();
    }

    public void OnAppear()
    {
        // Ничего не делаем
    }

    public void OnDisappear()
    {
        // Остановка анимаций или другие действия
    }

    public void UpdateBehavior()
    {
        // Повторяем действия игрока
        if (_playerContext.IsAttacking())
        {
            _animator.SetTrigger("Attack");
        }
        else
        {
            _animator.SetTrigger("Idle");
        }
    }
}
