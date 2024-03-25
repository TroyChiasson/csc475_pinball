// DO NOT USE! THIS IS OLD CODE!

using System;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    // Create a score for the instance with a public getter and private setter
    // public static Score Instance { get {return instance;} private set;}  = 0;
    private static Score instance;
    public static Score Instance {
        get { return instance; }
    }
    
    // Private score variable
    private int score = 0;
    // Initialize the instance
    

    // Function for other scripts to add points to the score
    public void IncrementScore(int points) {
        score += points;
        Debug.Log("Score: " + score);
    }

    // Function to reset the game's score (Restart)
    public void ResetScore() {
        score = 0;
    }


    // [[ Leaderboard stuff ]] 
    // Class structure to store name and score pairs
    [Serializable]
    public class PlayerScore {
        public string playerName;
        public int score;
    }

    // Create a list of name/score pairs (leaderboard list)
    private List<PlayerScore> leaderboard = new List<PlayerScore>();
    // Refrence to the key for PlayerPrefs
    private const string LBKey = "Leaderboard";

    private void Start() {
        instance = this;

        // Read what's stored in PlayerPrefs
        string leaderboardJson = PlayerPrefs.GetString(LBKey);
        // If empty, create a new empty leaderboard
        if (string.IsNullOrEmpty(leaderboardJson)) {
            leaderboard = new List<PlayerScore>();
            return;
        }
        // Deserialize the JSON string and populate the leaderboard list
        leaderboard = JsonUtility.FromJson<List<PlayerScore>>(leaderboardJson);
    }

    // Submit an entry to the leaderboard.
    // may need to be public. On a game over, do Score.Instance.SubmitScore("name")
    private void SubmitScore(string playerName) {
        // Create a new entry, populate it.
        PlayerScore entry = new PlayerScore();
        entry.playerName = playerName;
        entry.score = score;
        // Add the entry to the leaderboard
        leaderboard.Add(entry);
        // Sort the leaderboard by score in descending order
        leaderboard.Sort((a, b) => b.score.CompareTo(a.score));
        // Ensure only top 10 scores are retained
        if (leaderboard.Count > 10) {
            leaderboard.RemoveAt(leaderboard.Count - 1);
        }
        // Save the updated leaderboard
        SaveLeaderboard();

        // Add global leaderboard support?
    }

    // Save the leaderboard to PlayerPrefs
    private void SaveLeaderboard() {
        // Convert the leaderboard to JSON
        string leaderboardJson = JsonUtility.ToJson(leaderboard);
        // Save the JSON string to PlayerPrefs
        PlayerPrefs.SetString(LBKey, leaderboardJson);
        PlayerPrefs.Save();
    }
}
