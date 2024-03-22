using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class Game : MonoBehaviour
{
    [HideInInspector] public LaunchBall input;
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

    
    void Update()
    {
        /*if (input.action.FlipperLeft.WasPressedThisFrame())
        {
            flipperLeft.Flip();
        }
        else if (input.action.FlipperRight.WasPressedThisFrame())
        {
            flipperRight.Flip();
        }*/
        if (input.action.launch.WasPressedThisFrame())
        {
            ball.Launch();
        }
    }
}
