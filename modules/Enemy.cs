// Enemy.cs
public class Enemy
{
    /// <summary>
    /// Вид противника.
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Является ли противник боссом.
    /// </summary>
    public bool isBoss { get; set; }

    /// <summary>
    /// Конструктор класса.
    /// </summary>
    public Enemy(string type, bool isBoss)
    {
        this.Type = type;
        this.isBoss = isBoss;
    }
    
    /// <summary>
    /// Атакует игрока.
    /// </summary>
    public void AttackPlayer()
    {
        // Логика атаки на игрока
    }

    /// <summary>
    /// Обрабатывает смерть врага.
    /// </summary>
    public void Die()
    {
        // Логика смерти врага
    }
}
