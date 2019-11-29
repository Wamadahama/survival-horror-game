using UnityEngine;
using System.Collections;

public class CharacterRender : MonoBehaviour
{
    Animator animator;
    public float speed = 1f;
    public int lastDirection; 
    public int currentDirection;

    public enum Directions {
        N,
        NW,
        W,
        SW,
        S,
        E,
        NE
    }


    public string[] faceDirections = {
            "FN", "FNW", "FW", "FSW", "FS", "FSE", "FE", "FNE"
    };

    public string[] runDirections = {
            "RN", "RNW", "RW", "RSW", "RS", "RSE", "RE", "RNE"
    };

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    public void SetSprite(Vector2 direction)
    {
        string[] movementMap = null;
        if (direction.magnitude < .01)
        {
            // only switch directions
            movementMap = faceDirections;
        }
        else
        {
            // use movement animations 
            movementMap = runDirections;
            lastDirection = GetDirection(direction, faceDirections.Length); 
        }

        animator.Play(movementMap[lastDirection], faceDirections.Length);
    }

    public int GetDirection(Vector2 direction, int muxBit)
    {
        // Get the angle of the direction 
        float angle = Vector2.SignedAngle(Vector2.up, direction.normalized);
        angle += ((360f / muxBit) / 2); // hacked from a tutorial 
        if (angle < 0)
        {
            angle += 360; 
        }

        float steps = angle / (360f / muxBit);
        Debug.Log(Mathf.FloorToInt(steps));
        return 0;
        //return Mathf.FloorToInt(steps); 
    }


    // Update is called once per frame
    void Update()
    {

    }
}
