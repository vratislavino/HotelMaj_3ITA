public interface IDamageable
{
    int Hp { get; set; }

    void TakeDamage(int amount);

    void Die();
}

