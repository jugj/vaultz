using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int schaden = 5;
    public float speed = 5;
    Vector2 richtung;
     private Rigidbody2D rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
{
    Debug.Log("Kugel trifft: " + other.gameObject.name);
    if(other.gameObject.CompareTag("gegner"))
        {
        leben hp = other.gameObject.GetComponent<leben>();

        if (hp != null)
        {
            hp.Schaden(schaden);
            Debug.Log("Schaden gemacht!");
        }

        Destroy(this.gameObject);
        }
}
public void SetRichtung (Vector2 richtung){
    this.richtung = richtung;
}

    void FixedUpdate()
    {
        rb.velocity = richtung * speed;
    }
}