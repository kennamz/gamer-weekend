using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyFish : MonoBehaviour
{
    public float Speed = 5f;
    private Transform _myTransform;
    private bool movingToTheRight = true;
    private Quaternion toTheRight = Quaternion.Euler(0, 180, 0);
    private Quaternion toTheLeft = Quaternion.Euler(0, 0, 0);
    private int state = 0; //0 is unhatched, 1 is newly hatched, 2 is fully hatched
    // Start is called before the first frame update
    void Start()
    {
        _myTransform = this.transform;

        Vector3 StartingPosition = new Vector3(3, -5, 0);
        _myTransform.position = StartingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == 0 && gameObject.activeSelf) //if eggs are just pressed
        {
            state = 1;
        }

        if (state == 1) //newly hatched, moving to place in fish tank
        {
            Vector3 TargetPosition = new Vector3(9, 1, 0);
            var moveAmount = Speed * Time.deltaTime;
            _myTransform.position = Vector3.MoveTowards(_myTransform.position, TargetPosition, moveAmount);
            if (_myTransform.position == TargetPosition)
            {
                state = 2;
            }
        }

        if (state == 2) //fully hatched, moving like normal
        {
            //"Edge" of fish tank (background): +/- 14 in the x direction
            if (_myTransform.position.x > 14)
            {
                movingToTheRight = false;
                _myTransform.rotation = toTheLeft;
            }
            else if (_myTransform.position.x < -14)
            {
                movingToTheRight = true;
                _myTransform.rotation = toTheRight;
            }
            move(movingToTheRight);
        }
    }

    void move(bool movingToTheRight)
    {
        var moveAmount = Speed * Time.deltaTime;
        if (movingToTheRight)
        {
            _myTransform.position += new Vector3(moveAmount, 0, 0);
        }
        else
        {
            _myTransform.position += new Vector3(-1 * moveAmount, 0, 0);
        }

    }
}
