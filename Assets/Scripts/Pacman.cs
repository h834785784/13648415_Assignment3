using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Pacman : MonoBehaviour
{

    public GameObject pacman;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    

    private Tweener tweener;

    public Animator anim;
    public AudioSource moving;

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        moving.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Auto moving
        if (pacman.transform.position.x > p1.transform.position.x && pacman.transform.position.y == p4.transform.position.y)
        {
            tweener.AddTween(pacman.transform, pacman.transform.position, p1.transform.position, 4f);
            anim.SetTrigger("left");

        }

        if (pacman.transform.position.y < p2.transform.position.y && pacman.transform.position.x == p1.transform.position.x)
        {
            tweener.AddTween(pacman.transform, pacman.transform.position, p2.transform.position, 4f);
            anim.SetTrigger("up");

        }


        if (pacman.transform.position.x < p3.transform.position.x && pacman.transform.position.y == p2.transform.position.y)
        {
            tweener.AddTween(pacman.transform, pacman.transform.position, p3.transform.position, 4f);
            anim.SetTrigger("right");

        }


        if (pacman.transform.position.y > p4.transform.position.y && pacman.transform.position.x == p3.transform.position.x)
        {
            tweener.AddTween(pacman.transform, pacman.transform.position, p4.transform.position, 4f);
            anim.SetTrigger("down");

        }
    }
}