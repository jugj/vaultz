using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int schaden = 5;
    Vector2 richtung;
    void OnTriggerEnter2D(Collider2D other)
{
    Debug.Log("Kugel trifft: " + other.gameObject.name);

    leben hp = other.gameObject.GetComponent<leben>();

    if (hp != null)
    {
        hp.Schaden(schaden);
        Debug.Log("Schaden gemacht!");
    }
}
public void SetRichtung (Vector2 richtung){
this.richtung = richtung;
}


}