using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //set in inspector
    public Ball ball;

    //
    [HideInInspector] public Pinballinput input;

    // Singleton instance
    //private static GameManager instance;

    // Public static property to access the instance
    public static GameManager Instance
    { get; private set; }


    // Public properties for game variables
    public int Score { get; private set; }
    public int Lives { get; private set; }
    public int ActiveBalls { get; private set; }

    // Leaderboard data structure
    private List<ScoreEntry> leaderboard = new List<ScoreEntry>();

    void Awake()
    {
        //
        input = new Pinballinput();

        // Enable player input
        input.Enable();

        // Initialize singleton instance
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Initialize game state
        ResetGame();

        // Show start ui
    }



    /* ===== GAME VARIABLES ===== */
    // Public method to change score
    public void AddScore(int amount)
    {
        Score += amount;
        Debug.Log("Score: " + Score);
    }

    // Public method to change life
    public void AddLife(int amount)
    {
        Lives += amount;
        Debug.Log("Lives: " + Lives);
        /*
        If life < 1, game over
        */
    }

    // Public method to change the number of active balls
    public void AddActiveBalls(int amount)
    {
        ActiveBalls += amount;
        Debug.Log("ActiveBalls: " + ActiveBalls);
    }



    /* ===== LEADERBOARD ===== */
    // Public method to add a score entry to the leaderboard
    public void AddToLeaderboard(string playerName, int score)
    {
        // Add the new score entry
        leaderboard.Add(new ScoreEntry(playerName, score));

        // Sort the leaderboard by score (descending order)
        leaderboard.Sort((a, b) => b.score.CompareTo(a.score));

        // Ensure only top 10 scores are retained
        if (leaderboard.Count > 10)
        {
            leaderboard.RemoveAt(leaderboard.Count - 1);
        }

        // Save leaderboard to PlayerPrefs
        SaveLeaderboard();
    }

    // Private method to load leaderboard from PlayerPrefs
    private void LoadLeaderboard()
    {
        // Read leaderboardjson from PlayerPrefs
        string leaderboardjson = PlayerPrefs.GetString("Leaderboard");

        // If empty, create a new empty leaderboard
        if (string.IsNullOrEmpty(leaderboardjson))
        {
            leaderboard = new List<ScoreEntry>();
            return;
        }

        // Deserialize the JSON string and populate the leaderboard list
        leaderboard = JsonUtility.FromJson<List<ScoreEntry>>(leaderboardjson);
    }

    // Private method to save leaderboard to PlayerPrefs
    private void SaveLeaderboard()
    {
        // Serialize the JSON string
        string leaderboardjson = JsonUtility.ToJson(leaderboard);

        // Write leaderboardjson to PlayerPrefs
        PlayerPrefs.SetString("Leaderboard", leaderboardjson);

        // Save PlayerPrefs
        PlayerPrefs.Save();
    }

    // Inner class for leaderboard entry
    [System.Serializable]
    public class ScoreEntry
    {
        public string playerName;
        public int score;

        public ScoreEntry(string name, int s)
        {
            playerName = name;
            score = s;
        }
    }



    /* ===== EVENTS =====*/
    // Public method to reset game state
    public void ResetGame()
    {
        Score = 0;
        Lives = 4;
        ActiveBalls = 1;
    }

    // Public method to end game
    private void GameOver()
    {
        // Disable player input
        input.Disable();

        // Show GameOver UI
    }

    // Objectives/quests/targets whatever
}

