using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //destroys cookies off screen
    private float topBound = 30;

    //destroys animals off screen
    private float lowerBound = -10;

    private float sideBound = 30;

    private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager =
  GameObject.Find("GameManager").GetComponent<GameManager>();
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
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
    
}
