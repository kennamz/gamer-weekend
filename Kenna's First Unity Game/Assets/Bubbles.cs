using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubbles : MonoBehaviour
{
    public float Speed = 5f;
    private Transform _myTransform;
    Vector3 StartingPosition;
    // Start is called before the first frame update
    void Start()
    {
        _myTransform = this.transform;
        StartingPosition = new Vector3(-7, -2.289078f, -1);
        _myTransform.position = StartingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf)
        {
            var moveAmount = Speed * Time.deltaTime;
            _myTransform.position += new Vector3(0, moveAmount, 0);
            if (_myTransform.position.y >= 13)
            {
                _myTransform.gameObject.SetActive(false);
                _myTransform.position = StartingPosition;
            }
        }
    }
}
