using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [HeaderAttribute("Movement Variables")]
    public float speedX;
    public int directionX;
    [HeaderAttribute("Speed Variables")]
    public float speedT;
    public int directionT;
    public bool equise;
    public int[] arrayNumbers;
    [RangeAttribute(1,100)]
    public int health = 0;
    private Rigidbody2D _compRigidbody;
    private SpriteRenderer _compSpriteRenderer;
    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector2(transform.position.x + speedX * Time.deltaTime, 0);
    }
    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(speedX * directionX,0);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "HorizontalWall")
        {
            if(directionX == 1)
            {
                directionX = -1;
                _compSpriteRenderer.flipX = true;
            }else if(directionX == -1)
            {
                directionX = 1;
                _compSpriteRenderer.flipX = false;
            }
        }
    }
}
