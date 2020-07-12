using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float movespeed = 1f;
    Rigidbody2D myRigibody;
    void Start()
    {
        myRigibody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (IsFacingRight())
        {
            myRigibody.velocity = new Vector2(movespeed, 0f);
        }
        else
        {
            myRigibody.velocity = new Vector2(-movespeed, 0f);
        }

    }

    bool IsFacingRight()
    {
        return transform.localScale.x > 0;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myRigibody.velocity.x)), 1f);
    }
}
