using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound;
    public AudioSource gameResetSound;
    public AudioSource gameOverSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.gameObject.name)
        {
            case "RacketPlayer1":
                this.racketSound.Play();
                break;
            case "RacketPlayer2":
                this.racketSound.Play();
                break;
            case "WallLeft":
                this.wallSound.Play();
                break;
            case "WallRight":
                this.wallSound.Play();
                break;
        }
    }

}
