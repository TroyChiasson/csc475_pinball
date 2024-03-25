// DO NOT USE! THIS IS OLD CODE!

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class Game : MonoBehaviour
{
    [HideInInspector] public Pinballinput input;
    public Flipper flipperLeft;
    public Flipper flipperRight;
    public Ball ball;

    public static Game Instance 
        { get; private set;  }
    void Awake()
    {
        input = new ();
        input.Enable();
        Instance = this;
    }

    
    public void BallFall() {

    }

    void Update()
    {
        if (input.action.flipL.WasPressedThisFrame())
        {
            flipperLeft.Flip();
        }
        else if (input.action.flipR.WasPressedThisFrame())
        {
            flipperRight.Flip();
        }
        if (input.action.launch.WasPressedThisFrame())
        {
            ball.Launch();
        }
    }
}
