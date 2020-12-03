using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        _rigidbody2D.velocity = new Vector2(horizontal, _rigidbody2D.velocity.y);
    }
}
