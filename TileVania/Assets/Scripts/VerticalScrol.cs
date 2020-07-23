using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalScrol : MonoBehaviour
{
    [Tooltip("Game Units Per Second")]
    [SerializeField] float scrollRate = .2f;

    private void Update()
    {
        float yMove = scrollRate * Time.deltaTime;
        transform.Translate(new Vector2(0f, yMove));
    }
}
