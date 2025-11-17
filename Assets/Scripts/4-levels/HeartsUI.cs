using UnityEngine;
using UnityEngine.UI;

public class HeartsUI : MonoBehaviour
{
    [SerializeField] private Image[] hearts;
    [SerializeField] private Color fullColor = Color.white;
    [SerializeField] private Color emptyColor = new Color(1f, 1f, 1f, 0.25f);

    public void UpdateHearts(int currentHealth, int maxHealth)
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (hearts[i] == null) continue;
            if (i < maxHealth)
            {
                hearts[i].enabled = true;
                hearts[i].color = (i < currentHealth) ? fullColor : emptyColor;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

    }
}
