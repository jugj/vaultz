using UnityEngine;
using TMPro;

public class HPAnzeige : MonoBehaviour
{
    public leben hp;
    public TextMeshProUGUI text;
    public string prefix;

    void Update()
    {
        text.text = prefix+ "HP: " + hp.aktuellerHP;
    }
}