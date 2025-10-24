using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public Vector3 speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position += speed;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
            Destroy(collider.gameObject);
        }
        if (collider.CompareTag("Boundary"))
        {
            Destroy(gameObject);
        }
    }
}
