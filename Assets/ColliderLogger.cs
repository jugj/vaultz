using UnityEngine;

public class Collider2DLogger : MonoBehaviour
{
    [SerializeField] private bool logTriggers = true;
    [SerializeField] private bool logCollisions = true;

    private void Log(string eventName, Component other)
    {
        Debug.Log(
            $"[{Time.frameCount}] {name} -> {eventName} with '{other.name}' ({other.GetType().Name})",
            this
        );
    }

    // Trigger Events
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (logTriggers)
            Log(nameof(OnTriggerEnter2D), other);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (logTriggers)
            Log(nameof(OnTriggerStay2D), other);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (logTriggers)
            Log(nameof(OnTriggerExit2D), other);
    }

    // Collision Events
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (logCollisions)
            Log(nameof(OnCollisionEnter2D), collision.collider);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (logCollisions)
            Log(nameof(OnCollisionStay2D), collision.collider);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (logCollisions)
            Log(nameof(OnCollisionExit2D), collision.collider);
    }
}