using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;
    void BounceFromRacket(Collision2D collision)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = collision.gameObject.transform.position;

        float racketHeight = collision.collider.bounds.size.y;
        float x;
        if(collision.gameObject.name == "RacketPlayer1")
        {
            x = 1;
        } else
        {
            x = -1;
        }
        float y = (ballPosition.y - racketPosition.y) / racketHeight;

        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.gameObject.name)
        {
            case "RacketPlayer1":
                this.BounceFromRacket(collision);
                break;
            case "RacketPlayer2":
                this.BounceFromRacket(collision);
                break;
            case "WallLeft":
                this.scoreController.GoalPlayer2();
                StartCoroutine(this.ballMovement.StartBall(true));
                break;
            case "WallRight":
                this.scoreController.GoalPlayer1();
                StartCoroutine(this.ballMovement.StartBall(false));
                break;
            default:
                break;
        }
    }
}
