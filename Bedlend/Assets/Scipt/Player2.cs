using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float moveSpeed = 5f; // �������� �����������
    public float jumpForce = 5f; // ���� ������
    public float jumpCooldown = 1f; // ����� �������� ����� ��������� �������
    private bool canJump = true; // ����, �����������, ����� �� ����� ��������
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // �������� ��������� Rigidbody2D
    }

    void Update()
    {
        MovePlayer(); // ������������ �������� ������
        Jump(); // ������������ ������
    }

    void MovePlayer()
    {
        float moveInput = Input.GetAxis("Horizontal"); // �������� ���� �� ��� X (�����/������)
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y); // ������������� �������� ��������
    }

    void Jump()
    {
        if (canJump && Input.GetKeyDown(KeyCode.Space)) // ���������, ����� �� ����� �������� � ������ �� ������� Space
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse); // ��������� ���� ��� ������
            canJump = false; // ������������� ����, ��� ����� �� ����� �������� �����
            StartCoroutine(JumpCooldown()); // ��������� �������� ��� �������� ������
        }
    }

    IEnumerator JumpCooldown()
    {
        yield return new WaitForSeconds(jumpCooldown); // ���� ��������� ����� ��������
        canJump = true; // ��������� ����� ������
    }
}
