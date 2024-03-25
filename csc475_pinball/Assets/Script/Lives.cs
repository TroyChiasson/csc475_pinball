// DO NOT USE! THIS IS OLD CODE!

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour {
    private static Lives instance;
    public static Lives Instance {
        get { return instance; }
    }

    private int lives = 3;

    // Start is called before the first frame update
    void Start() {
        instance = this;
    }

    // Public method to change life (negative amount to decrease)
    public void AddLife(int amount) {
        lives += amount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
