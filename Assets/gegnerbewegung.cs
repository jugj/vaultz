using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gegnerbewegung : MonoBehaviour
{ [SerializeField]public Transform target;
public float Geschwindigkeit = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = 1f* Geschwindigkeit * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target.position, step);
    }
}
