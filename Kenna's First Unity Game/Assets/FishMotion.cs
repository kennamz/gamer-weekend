using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMotion : MonoBehaviour
{
    public float Speed = 5f;
    private Transform _myTransform;
    private bool movingToTheRight = true;
    private Quaternion toTheRight = Quaternion.Euler(0, 180, 0);
    private Quaternion toTheLeft = Quaternion.Euler(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        _myTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
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
