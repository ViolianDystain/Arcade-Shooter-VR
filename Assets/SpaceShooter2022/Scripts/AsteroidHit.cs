using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHit : MonoBehaviour
{
    [SerializeField] private GameObject asteroidExplosion;
    [SerializeField] private GameController gameController;


    private void Awake()
    {
        gameController = FindAnyObjectByType<GameController>();
    }

    public void AsteroidDestroyed()
    {
        Instantiate(asteroidExplosion, transform.position, transform.rotation);

        float distanceFromPlayer = Vector3.Distance(transform.position, Vector3.zero);
        int bonusPoints = (int)distanceFromPlayer;

        int asteroidScore = 10*bonusPoints;

        gameController.UpdatePlayerScore(asteroidScore);



        Destroy(this.gameObject);
    }
}
