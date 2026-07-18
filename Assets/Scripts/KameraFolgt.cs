using UnityEngine;

public class KameraFolgt : MonoBehaviour
{
    public Transform spieler;
    public float geschwindigkeit = 5f;

    void LateUpdate()
    {
        if (spieler == null)
            return;

        Vector3 ziel = new Vector3(
            spieler.position.x,
            spieler.position.y,
            -10f
        );

        transform.position = Vector3.Lerp(
            transform.position,
            ziel,
            geschwindigkeit * Time.deltaTime
        );
    }
}