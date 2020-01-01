using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float movementSpeed;
    public float extraSpeedPerHit;
    public float maxExtraSpeed;
    
    private int hitCounter;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.StartBall());
    }

    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this.PositionBall(isStartingPlayer1);
        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingPlayer1)
        {
            this.MoveBall(new Vector2(-1, 0));
        } else
        {
            this.MoveBall(new Vector2(1, 0));
        }

    }

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;
        float speed = this.movementSpeed + this.hitCounter * this.extraSpeedPerHit;

        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = direction * speed;

    }

    public void IncreaseHitCounter()
    {
        if(this.hitCounter * this.extraSpeedPerHit < this.movementSpeed + this.maxExtraSpeed )
        {
            this.hitCounter++;
        }
    }

    void PositionBall(bool isStartingPlayer1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        if(isStartingPlayer1)
        {
            this.gameObject.transform.localPosition = new Vector3(-50, 0, 0);
        } else
        {
            this.gameObject.transform.localPosition = new Vector3(50, 0, 0);
        }
    }
}
