using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    private int score = 0;

    public void IncrementScore(int points) {
        score += points;
        Debug.Log("Score: " + score);
    }

    public void ResetScore() {
        score = 0;
    }
}
