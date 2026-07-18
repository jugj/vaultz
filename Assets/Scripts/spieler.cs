using UnityEngine;

public class spieler : MonoBehaviour
{
    public float geschwindigkeit = 5f;
    public float sprintGeschwindigkeit = 8f;

    private int hp;

    private Rigidbody2D rb;
    private Vector2 bewegung;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {

        bewegung = Vector2.zero;
        if (Input.GetKey(KeyCode.A)) {
            bewegung.x = -1f;
        }
        if (Input.GetKey(KeyCode.D)) {
            bewegung.x = 1f;
        }
        if (Input.GetKey(KeyCode.W)) {
            bewegung.y = 1f;
        }
        if (Input.GetKey(KeyCode.S)) {
            bewegung.y = -1f;
        }
    }

    void FixedUpdate()
    {
        float speed = geschwindigkeit;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = sprintGeschwindigkeit;
        }

        

        rb.velocity = bewegung * speed;
    }

    public void Schaden(int schaden)
    {
        hp -= schaden;

        Debug.Log("HP: " + hp);

        if (hp <= 0)
        {
            Debug.Log("Spieler tot");
            Destroy(gameObject);
        }
    }
}