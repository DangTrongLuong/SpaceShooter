 using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    private int healthPoint;
    public System.Action onDead;

    private void Start() => healthPoint = defaultHealthPoint;

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;
        if (healthPoint <= 0) Die();
    }


    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position,
        transform.rotation);
        Destroy(explosion, 0.3f);
        Destroy(gameObject);
        onDead?.Invoke();
    }

}