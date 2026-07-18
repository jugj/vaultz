using UnityEngine;

public class Schießen : MonoBehaviour
{
    public GameObject kugel;
    public Transform schussPunkt;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 maus = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            maus.z = 0;

            Vector2 richtung = maus - schussPunkt.position;


            GameObject neueKugel = Instantiate(
                kugel,
                schussPunkt.position,
                Quaternion.identity
            );


            neueKugel.GetComponent<Bullet>().SetRichtung(richtung);
        }
    }
}