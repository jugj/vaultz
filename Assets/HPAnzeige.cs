using UnityEngine;
using TMPro;

public class HPAnzeige : MonoBehaviour
{
    public leben hp;
    public TextMeshProUGUI text;

    void Update()
    {
        text.text = "HP: " + hp.aktuellerHP;
    }
}