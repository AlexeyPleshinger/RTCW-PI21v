// PlayerMovement.cs
public class PlayerMovement
{
    public float Sensitivity { get; set; } = 1.0f;

    public void HandleInput()
    {
        // Обработка нажатия клавиш
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) { MovePlayer(); }
        if (Input.GetKeyDown(KeyCode.Space)) { Jump(); }
	if (Input.GetKeyDown(KeyCode.С)) { Crouch(); }
    }

    private void MovePlayer() { /* Логика движения игрока */ }
    private void Jump() { /* Логика прыжка */ }
    private void Crouch() { /* Логика передвижения в присяди */ }
    private void RotateCamera() { /* Логика вращения камеры */}
    private void Swim() { /* Логика плавания */}
    private void Dodge() { /* Логика уклонения */}
}