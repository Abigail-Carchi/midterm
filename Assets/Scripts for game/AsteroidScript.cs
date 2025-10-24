using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public Vector3 fall;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position += fall;
    }
}
