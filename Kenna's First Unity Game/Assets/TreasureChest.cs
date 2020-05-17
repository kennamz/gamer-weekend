using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    private Transform _myTransform;

    private int count = 0;
    public int Timer = 160; //determines how often the bubble will be released
    public int openTime = 120;
    public Sprite chestOpen;
    public Sprite chestClosed;

    private GameObject bubbles;
    private Transform _bubblesTransform;
    // Start is called before the first frame update
    void Start()
    {
        _myTransform = this.transform;

        bubbles = GameObject.Find("bubbles");
        _bubblesTransform = bubbles.transform;
        _bubblesTransform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count >= Timer)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = chestOpen;
            count = -1 * openTime;
            _bubblesTransform.gameObject.SetActive(true);
        }
        else if (count < 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = chestOpen;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = chestClosed;
        }
    }
}
