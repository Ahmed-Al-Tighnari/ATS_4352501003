using UnityEngine;

public class Koin : MonoBehaviour
{
    public int poin = 10;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindAnyObjectByType<Skor>().Tambah(poin);
            Debug.Log("Koin diambil!");
            Destroy(gameObject);
        }
    }
}