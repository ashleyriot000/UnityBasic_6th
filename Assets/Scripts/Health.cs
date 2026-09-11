using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider healthbar;
    public int maxHealth = 1;
    public Transform effectTransform;
    public GameObject destroyEffect;
    public Transform camTransform;
    private int currentHp;

    void Start()
    {
        currentHp = maxHealth;

        if(healthbar != null)
        {
            healthbar.wholeNumbers = true;
            healthbar.maxValue = maxHealth;
            healthbar.value = maxHealth;
        }
    }
    public void TakeDamage(int damamge)
    {
        currentHp = Mathf.Clamp(currentHp - damamge, 0, maxHealth);
        if(healthbar != null)
        {
            healthbar.value = currentHp;
        }
        Debug.Log($"TakeDmg => {gameObject.name}({currentHp})");
        if(currentHp == 0)
        {
            if(camTransform != null)
                camTransform.SetParent(null);
            Destroy(gameObject);
            if (destroyEffect != null)
                Instantiate(destroyEffect, effectTransform.position, effectTransform.rotation);
        }
    }
}
