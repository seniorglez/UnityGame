using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public double amountToMove;
    public float speed;
    private float startx;
    private int direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = 0;
        startx = gameObject.transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x < startx + amountToMove && direction == 0)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x + speed*Time.deltaTime, gameObject.transform.position.y);

        }
        else if(gameObject.transform.position.x >= startx + amountToMove && direction == 0)
        {
            direction = 1;
        }
        else if (gameObject.transform.position.x > startx && direction == 1)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x - speed*Time.deltaTime, gameObject.transform.position.y);

        }
        else if (gameObject.transform.position.x <= startx && direction == 1)
        {
            direction = 0;
        }
    }
}
