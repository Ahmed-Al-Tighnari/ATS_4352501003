using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{
    public Text teksSkor;
    private int nilai = 0;

    void Start()
    {
        Tampilkan();
    }

    public void Tambah(int jumlah)
    {
        nilai = nilai + jumlah;
        Tampilkan();
    }

    void Tampilkan()
    {
        teksSkor.text = "Skor: " + nilai;
    }
}