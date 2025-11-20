using UnityEngine;
using TMPro; // Penting: Pastikan Anda menggunakan TextMeshPro di Unity
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public int coinCount;
    public TextMeshProUGUI coinText;

    void Start()
    {

    }

    void Update()
    {
        coinText.text = coinCount.ToString();

    }
}