using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость перемещения
    public float jumpForce = 5f; // Сила прыжка
    public float jumpCooldown = 1f; // Время задержки перед следующим прыжком
    private bool canJump = true; // Флаг, указывающий, может ли игрок прыгнуть
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Получаем компонент Rigidbody2D
    }

    void Update()
    {
        MovePlayer(); // Обрабатываем движение игрока
        Jump(); // Обрабатываем прыжок
    }

    void MovePlayer()
    {
        float moveInput = Input.GetAxis("Horizontal"); // Получаем ввод по оси X (влево/вправо)
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y); // Устанавливаем скорость движения
    }

    void Jump()
    {
        if (canJump && Input.GetKeyDown(KeyCode.Space)) // Проверяем, может ли игрок прыгнуть и нажата ли клавиша Space
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse); // Применяем силу для прыжка
            canJump = false; // Устанавливаем флаг, что игрок не может прыгнуть снова
            StartCoroutine(JumpCooldown()); // Запускаем корутину для задержки прыжка
        }
    }

    IEnumerator JumpCooldown()
    {
        yield return new WaitForSeconds(jumpCooldown); // Ждем указанное время задержки
        canJump = true; // Разрешаем новый прыжок
    }
}
