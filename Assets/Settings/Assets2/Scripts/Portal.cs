using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    // Variabel yang bisa diatur di Inspector Unity:
    public float moveSpeed = 2f; // Kecepatan bergerak
    public float patrolDistance = 5f; // Jarak total yang akan ditempuh (misal 5 meter ke kiri dan kanan dari titik awal)

    private Vector3 startPosition; // Posisi awal musuh
    private int direction = 1;     // 1 = Kanan, -1 = Kiri



    void Start()
    {
        // Menyimpan posisi awal objek saat game dimulai
        startPosition = transform.position;
    }

    void Update()
    {
        // 1. Hitung Posisi Baru
        // Bergerak ke kanan (1) atau kiri (-1) berdasarkan variabel 'direction'
        transform.Translate(Vector2.right * direction * moveSpeed * Time.deltaTime);

        // 2. Cek Batas Pergerakan
        float currentDistance = transform.position.x - startPosition.x;

        // Jika sudah mencapai batas kanan
        if (currentDistance > patrolDistance)
        {
            // Balik arah ke kiri
            direction = -1;
            // Panggil fungsi untuk membalik tampilan sprite
            FlipSprite();
        }
        // Jika sudah mencapai batas kiri
        else if (currentDistance < -patrolDistance)
        {
            // Balik arah ke kanan
            direction = 1;
            // Panggil fungsi untuk membalik tampilan sprite
            FlipSprite();
        }
    }

    // Fungsi untuk membalik tampilan sprite agar terlihat berbalik badan
    void FlipSprite()
    {
        // Mengambil komponen SpriteRenderer
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        // Membalik nilai flipX: Jika true menjadi false, jika false menjadi true
        spriteRenderer.flipX = direction == -1;
    }
}