using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{   
    [SerializeField] GameObject Monster;
    public float counter = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        counter=counter-Time.deltaTime;
        if (counter<=0){
            Instantiate(Monster, this.transform.position, Quaternion.identity);
            counter=10;
        }
        
    }
}
