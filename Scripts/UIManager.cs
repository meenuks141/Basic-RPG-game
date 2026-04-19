using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public TextMeshProUGUI healthText;

    void Update()
    {
        healthText.text = "Health: " + playerHealth.currentHealth;
    }
}