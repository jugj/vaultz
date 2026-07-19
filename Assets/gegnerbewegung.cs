using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gegnerbewegung : MonoBehaviour
{ 
    [SerializeField]
    public Transform target;

    Rigidbody2D rb;
public float Geschwindigkeit = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target=GameObject.FindWithTag("Tresor").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector2 newPosition = Vector2.MoveTowards(
            rb.position,
            target.position,
            Geschwindigkeit * Time.fixedDeltaTime);

        rb.MovePosition(newPosition);
    }
}
