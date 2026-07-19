using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Lebensmonitor : MonoBehaviour
{   

    float counter = 0;
    public GameObject player;
    public GameObject Tresor;
    public TextMeshProUGUI final_text;
    public GameObject final_text_object;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (player!=null && Tresor!=null){
            counter = counter + Time.deltaTime;
        }
        if (player==null){
            final_text_object.SetActive(true);
            final_text.text = "GAMEOVER! Du hast so viele Sekunden überlebt: "+counter;
        }
        if (Tresor==null){
            final_text_object.SetActive(true);
            final_text.text = "GAMEOVER! Der Tresor hat so viele Sekunden überlebt: "+counter;
        }
    }
}
