using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    private OldInput _oldInput; 
    private Rigidbody2D _rigidbody;

    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        _oldInput = GetComponent<OldInput>();
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        _rigidbody.velocity = new Vector2(_oldInput.horizontal * speed, _rigidbody.velocity.y);
    }
}
