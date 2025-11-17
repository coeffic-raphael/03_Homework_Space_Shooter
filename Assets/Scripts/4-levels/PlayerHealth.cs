using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 3;
    [SerializeField] private HeartsUI heartsUI;

    private int currentHealth;

    private void Start()
    {
        GlobalHealth.Max = maxHealth;
        heartsUI.UpdateHearts(GlobalHealth.Current, GlobalHealth.Max);
    }

    public void TakeDamage(int amount)
    {
        if (GlobalHealth.Current <= 0) return;

        GlobalHealth.Current -= amount;

        if (GlobalHealth.Current < 0)
        {
            GlobalHealth.Current = 0;
        }
        if (heartsUI != null)
        {
            heartsUI.UpdateHearts(GlobalHealth.Current, GlobalHealth.Max);
        }

        if (GlobalHealth.Current <= 0)
        {
            Debug.Log("Player dead");
            AudioManager.Instance.StopMusic();
            AudioManager.Instance.PlayGameOver();
            SceneManager.LoadScene("level-game-over");
        }
    }

    public void AddHealth(int amount)
    {
        if (GlobalHealth.Current <= 0) return;

        GlobalHealth.Current += amount;
        if (GlobalHealth.Current > maxHealth)
        {
            GlobalHealth.Current = maxHealth;
        }

        if (heartsUI != null)
        {
            heartsUI.UpdateHearts(GlobalHealth.Current, GlobalHealth.Max);

        }
    }
}