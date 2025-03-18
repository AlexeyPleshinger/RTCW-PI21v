// PlayerMovement.cs
public class PlayerMovement
{
    /// <summary>
    /// Чувствительность управления.
    /// </summary>
    public float Sensitivity { get; set; } = 1.0f;

    /// <summary>
    /// Обрабатывает ввод от игрока.
    /// </summary>
    public void HandleInput()
    {
        // Обработка нажатия клавиш
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            MovePlayer();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Crouch();
        }
    }

    /// <summary>
    /// Передвижение игрока.
    /// </summary>
    private void MovePlayer() { /* Логика движения игрока */ }

    /// <summary>
    /// Функция прыжка.
    /// </summary>
    private void Jump() { /* Логика прыжка */ }

    /// <summary>
    /// Функция ходьбы в присяди.
    /// </summary>
    private void Crouch() { /* Логика передвижения в присяди */ }

    /// <summary>
    /// Функция вращения камеры.
    /// </summary>
    private void RotateCamera() { /* Логика вращения камеры */ }
    /// <summary>
    /// Функция плавания игрока.
    /// </summary>
    private void Swim() { /* Логика плавания */ }

    /// <summary>
    /// Функция уклона вправо/влево.
    /// </summary>
    private void Dodge() { /* Логика уклонения */ }
}