// Enemy.cs
public class Enemy
{
    public string Type { get; set; } // Вид противника
    public bool isBoss { get; set; } // Является боссом или обычным врагом

    public void AttackPlayer()
    {
        // Логика атаки на игрока
    }

    public void Die()
    {
        // Логика смерти врага
    }
}