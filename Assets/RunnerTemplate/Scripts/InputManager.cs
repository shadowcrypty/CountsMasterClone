using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;
    public GameObject player;
    public float forwardSpeed;
    public ClampObjectPosition clampObject = new ClampObjectPosition();
    public EditorInput editorInput = new EditorInput();
    public MobileInput mobile = new MobileInput();

    public Runner runner = new Runner();

    public Vector3 LeftBottomBackCorner;
    public Vector3 RightUpFrontCorner;
    private float _move;

    public static InputManager Instance { get { return _instance; } }
    private void OnEnable()
    {
        _instance = this;
        StopPlayer();

    }
    public void StopPlayer()
    {
        _move = 0;
    }
    public void MovePlayer()
    {
        _move = 1;
        PlayerAnimation.isSprinting = true;
        PlayerAnimation.isFighting = false;



    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MovePlayer();
        }
        
        if (GameManager.Instance.State==GameManager.GameStatus.playing)
        {
            runner.MoveForward(player, forwardSpeed*_move);
            //editor input
            runner.MoveHorizontal(player, editorInput.Horizontal*_move);
            //mobile input
           // runner.MoveHorizontal(player, mobile.Horizontal);
            clampObject.Clamp(player, LeftBottomBackCorner, RightUpFrontCorner);
        }
        else
        {
            runner.MoveForward(player, 0);
        }


    }
}
