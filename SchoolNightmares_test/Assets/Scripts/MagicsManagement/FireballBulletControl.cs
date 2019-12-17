using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballBulletControl : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    private Vector2 direction;


    // Start is called before the first frame update
    void Start() {

        // Get rigidbody and sprite renderer components
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Get direction thanks to the animations
        string anim = BoyAnimation.currentDirection;

        switch (anim){
            case "Static N":
            case "Run N":
                direction = new Vector2(0f, 1f);
                //spriteRenderer.sprite = Resources.Load<Sprite>("fireball_1_19");
                break;
            case "Static NW":
            case "Run NW":
                direction = new Vector2(-1f, 1f);
                //spriteRenderer.sprite = Resources.Load<Sprite>("fireball_1_8"); 
                break;
            case "Static W":
            case "Run W":
                direction = new Vector2(-1f, 0f);
                //spriteRenderer.sprite = Resources.Load<Sprite>("fireball_1_4"); 
                break;
            case "Static SW":
            case "Run SW":
                direction = new Vector2(-1f, -1f);
                //spriteRenderer.sprite = Resources.Load<Sprite>("fireball_1_58"); 
                break;
            case "Static S":
            case "Run S":
                direction = new Vector2(0f, -1f);
                //spriteRenderer.sprite = Resources.Load<Sprite>("fireball_1_51"); 
                break;
            case "Static SE":
            case "Run SE":
                direction = new Vector2(1f, -1f);
                //spriteRenderer.sprite = Resources.Load<Sprite>("fireball_1_44"); 
                break;
            case "Static E":
            case "Run E":
                direction = new Vector2(1f, 0f);
                break;
            case "Static NE":
            case "Run NE":
                direction = new Vector2(1f, 1f);
                //spriteRenderer.sprite = Resources.Load<Sprite>("fireball_1_25");
                break;
            default:
                print("Fireball DIRECTION ERROR!");
                break;
        }

        rb.velocity = direction * speed;
        print("Direction" + anim);
    }


    void OnTriggerEnter2D(Collider2D other){

        // Just if it hits the ice destroy the other object
        if(other.CompareTag("IceElement")){
            print("Hit ice block");
            Destroy(other.gameObject);
        } else if(other.CompareTag("Player")){
            return;
        }

        Destroy(gameObject);
    }
}
