using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int schaden = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Etwas hat mich berührt!");

        if(collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Tresor") )
        {
            Debug.Log("Spieler getroffen!");

            leben hp = collision.gameObject.GetComponent<leben>();

            if(hp != null)
            {
                hp.Schaden(schaden);
            }
        }

        if(collision.gameObject.CompareTag("Tresor") )
        {
            Debug.Log("Tresor getroffen!");

            leben hp = collision.gameObject.GetComponent<leben>();

            if(hp != null)
            {
                hp.Schaden(schaden);
            }

            Destroy(gameObject);
        }
    }
}