using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //destroys cookies off screen
    private float topBound = 30;

    //destroys animals off screen
    private float lowerBound = -10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        } }
    
}
