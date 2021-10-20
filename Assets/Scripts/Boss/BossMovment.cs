using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovment : MonoBehaviour
{
    public Boss[] prefabs;

    public int rows = 1;

    public int colums = 1;

    public float speed = 10.0f;

    private Vector3 _direction = Vector2.right;


    private void Awake()
    {
        for (int row = 0; row < this.rows; row++)
        {
            float width = 2.0f * (this.colums - 1);
            float height = 2.0f * (this.rows - 1);
            Vector2 centering = new Vector2(-width / 2, -height / 2);
            Vector3 rawPosition = new Vector3(centering.x, centering.y + (row * 2.0f), 0.0f);


        }
    }

    private void Update()
    {
        this.transform.position += _direction * this.speed * Time.deltaTime; // 

        Vector3 leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero); //  Just a simple way to get worldspace coordinates using the transform function that Unity provides
        Vector3 rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);//

        foreach (Transform boss in this.transform)
        {
            if (this._direction == Vector3.right && boss.position.x >= (rightEdge.x - 1.0f)) // if our direction is movin to the right && we need to check the position of the rat on the right side of the screen. So if the rat position is greater than or equal to our rightedge dot x then we know we need to ... flip ?
            {
                AdvanceRow();
                break;
            }
            else if (_direction == Vector3.left && boss.position.x <= leftEdge.x + 1.0f)
            {
                AdvanceRow();
                break;
            }


        }
    }
    private void AdvanceRow()
    {
        _direction.x *= -1.0f; // so direction.x *= -1 which will just negate it or you could say that if it's positive it'll go negative, if it's negative it'll go positive

        Vector3 position = this.transform.position; // we take their current position this.transform.position
        position.y = 1.0f; // we just like update the Y to be one unite less which will move to the next row
        this.transform.position = position; // we just assigne this back to our transform




    }

}

