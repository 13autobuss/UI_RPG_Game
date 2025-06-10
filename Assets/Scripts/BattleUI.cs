using UnityEngine;
using TMPro;
public class BattleUI : MonoBehaviour
{
    public TMP_Text playerName;
    public TMP_Text playerHP;
    public TMP_Text playerShield;
    public TMP_Text dialogueText;

    public void SetUI(Unit unit)
    {
        playerName.Text = unit.unitName;
        playerHP.Text = "HP: " + currentHP;
        playerShield.Text = "Shield: " + currentShield;
    }
}
