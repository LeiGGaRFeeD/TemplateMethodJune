using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AttackPerformer : MonoBehaviour
{
    public Button attack1Button;
    public Button attack2Button;
    public Button attack3Button;

    public CharacterContext character;
    public EnemyManager enemyManager;

    private void Start()
    {
        attack1Button.onClick.AddListener(() => SetAttackStrategy(new AttackType1(character.GetComponent<Animator>()), attack1Button));
        attack2Button.onClick.AddListener(() => SetAttackStrategy(new AttackType2(character.GetComponent<Animator>()), attack2Button));
        attack3Button.onClick.AddListener(() => SetAttackStrategy(new AttackType3(character.GetComponent<Animator>()), attack3Button));
        
        SetAttackStrategy(new AttackType1(character.GetComponent<Animator>()), attack1Button); // Устанавливаем стратегию по умолчанию
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            character.PerformAttack();
            Invoke(nameof(EndCharacterAttack), 1.0f); // Пример вызова EndAttack через 1 секунду
        }
    }

    private void EndCharacterAttack()
    {
        character.EndAttack();
    }

    private void SetAttackStrategy(IAttackStrategy strategy, Button button)
    {
        character.SetStrategy(strategy);
        HighlightButton(button);
        enemyManager.ChangeEnemy();
    }

    private void HighlightButton(Button buttonToHighlight)
    {
        Button[] buttons = { attack1Button, attack2Button, attack3Button };

        foreach (Button button in buttons)
        {
            ColorBlock colors = button.colors;
            if (button == buttonToHighlight)
            {
                colors.normalColor = Color.yellow; // Подсвеченный цвет
            }
            else
            {
                colors.normalColor = Color.white; // Обычный цвет
            }
            button.colors = colors;
        }
    }
}
