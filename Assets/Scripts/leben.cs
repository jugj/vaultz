using UnityEngine;
using UnityEngine.UI;

public class leben : MonoBehaviour
{
    public int maxHP = 100;
    public int aktuellerHP;

    public Slider hpLeiste;


    void Start()
    {
        aktuellerHP = maxHP;

        if (hpLeiste != null)
        {
            hpLeiste.maxValue = maxHP;
            hpLeiste.value = aktuellerHP;
        }
    }


    public void Schaden(int menge)
    {
        aktuellerHP -= menge;

        Debug.Log(gameObject.name + " hat noch " + aktuellerHP + " HP");


        if (hpLeiste != null)
        {
            hpLeiste.value = aktuellerHP;
        }


        if (aktuellerHP <= 0)
        {
            Sterben();
        }
    }


    void Sterben()
    {
        Debug.Log(gameObject.name + " ist tot!");
        Destroy(gameObject);
    }
}