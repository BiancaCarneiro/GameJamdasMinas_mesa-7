public class HealthSystem
{
    private int maxHealth;
    private int health;

    public HealthSystem(int maxHealth)
    {
        this.maxHealth = maxHealth;
        health = maxHealth;
    }

    public int GetHealth()
    {
        return health;
    }

    public void Damage(int damageTaken)
    {
        health -= damageTaken;

        if (health < 0)
        {
            health = 0;
        }
    }
}
