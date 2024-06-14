using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private int _currentEnemyIndex = 0;
    private GameObject _currentEnemy;
    private IEnemyBehavior _currentBehavior;

    public void ChangeEnemy()
    {
        if (_currentEnemy != null)
        {
            _currentBehavior.OnDisappear();
            Destroy(_currentEnemy);
        }

        _currentEnemyIndex = (_currentEnemyIndex + 1) % enemyPrefabs.Length;
        _currentEnemy = Instantiate(enemyPrefabs[_currentEnemyIndex]);
        _currentBehavior = _currentEnemy.GetComponent<IEnemyBehavior>();
        _currentBehavior.OnAppear();
    }

    private void Update()
    {
        _currentBehavior?.UpdateBehavior();
    }
}
