using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public ParticleSystem coinPoofPrefab;
    public ScoreCalculator score;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        Instantiate(coinPoofPrefab, transform.position, Quaternion.Euler(-90f, 180f, -90f));
        score.AddScore();
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }


}
