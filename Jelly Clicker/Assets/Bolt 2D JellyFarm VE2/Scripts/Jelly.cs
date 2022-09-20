using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jelly : MonoBehaviour
{
    public int id;
    public int level;
    public float exp;
    public float required_exp;
    public float max_exp;

    public GameManager game_manager;

    int move_delay;
    int move_time;

    float speed_x;
    float speed_y;

    bool isWandering;
    bool isWalking;

    public SpriteRenderer sprite;
    Animator anim;

    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        isWandering = false;
        isWalking = false;
    }

    void Update()
    {
        if(exp < max_exp)
            exp += Time.deltaTime;

        if (exp > required_exp * level && level < 3)
            game_manager.ChangeAc(anim, ++level);
    }

    void FixedUpdate()
    {
        if (!isWandering)
            StartCoroutine(Wander());
        if (isWalking)
            Move();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Bottom") || collision.gameObject.name.Contains("Top"))
            speed_y = -speed_y;
        else if (collision.gameObject.name.Contains("Left") || collision.gameObject.name.Contains("Right"))
            speed_x = -speed_x;
         }

    void OnMouseDown()
    {
        isWalking = false;
        anim.SetBool("isWalk", false);
        anim.SetTrigger("doTouch");

        if(exp < max_exp) ++exp;

        if (game_manager.jelatin < 99999999)
            game_manager.jelatin += (id + 1) * level;
    }

    void Move()
    {
        if (speed_x != 0)
            sprite.flipX = speed_x < 0;

        transform.Translate(speed_x, speed_y, speed_y);
    }

    IEnumerator Wander()
    {
        move_delay = 6;
        move_time = 3;
        speed_x = Random.Range(-0.8f, 0.8f) * Time.deltaTime;
        speed_y = Random.Range(-0.8f, 0.8f) * Time.deltaTime;

        isWandering = true;

        yield return new WaitForSeconds(move_delay);

        isWalking = true;
        anim.SetBool("isWalk", true);

        yield return new WaitForSeconds(move_time);
        
        isWalking = false;
        anim.SetBool("isWalk", false);

        isWandering = false;
    }
}