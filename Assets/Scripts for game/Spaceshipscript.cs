using UnityEngine;

public class Spaceshipscript : MonoBehaviour
{
    public Vector3 updirection;
    public Vector3 downdirection;
    public GameObject projectile;
    public GameObject gameManager;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Transform>().position += updirection;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Transform>().position += downdirection;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, transform.position + new Vector3(1, 0, 0), transform.rotation);
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
            Destroy(collider.gameObject);
            gameManager.GetComponent<GMScript>().GameOver();
        }
    }
}
