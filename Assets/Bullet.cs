void OnTriggerEnter2D(Collider2D other)
{
    Debug.Log("Kugel trifft: " + other.gameObject.name);

    leben hp = other.GetComponent<leben>();

    if (hp != null)
    {
        hp.Schaden(schaden);
        Debug.Log("Schaden gemacht!");
    }
}