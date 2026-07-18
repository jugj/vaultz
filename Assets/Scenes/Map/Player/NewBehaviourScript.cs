using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        bool topPressed = Input.GetKey(KeyCode.W);
        bool leftPressed = Input.GetKey(KeyCode.A);
        bool bottomPressed = Input.GetKey(KeyCode.S);
        bool rightPressed = Input.GetKey(KeyCode.D);

        if(topPressed || leftPressed || bottomPressed || rightPressed) {
            anim.SetBool("Player_Moving", true);
        }
        else {
            anim.SetBool("Player_Moving", false);
        }

        
        if(leftPressed) {
            anim.SetBool("Player_Left", true);
        }
        else if(rightPressed) {
            anim.SetBool("Player_Left", false);
        }
    }
}
