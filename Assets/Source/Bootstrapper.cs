using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bootstrapper : MonoBehaviour
{
    public CharacterContext character;
    public EnemyManager enemyManager;
    public AttackPerformer attackPerformer;

    private void Awake()
    {
        attackPerformer.character = character;
        attackPerformer.enemyManager = enemyManager;
    }
}
