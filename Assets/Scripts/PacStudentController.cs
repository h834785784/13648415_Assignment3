using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PacStudentController : MonoBehaviour
{
    [SerializeField] private GameObject item;
    private Tweener tweener;

    Vector2 dis = Vector2.zero;

    public Animator pacAnim;
    public AudioSource moving;



    // Use this for initialization
    void Start()
    {
        tweener = GetComponent<Tweener>();
        dis = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        float beginX = transform.position.x;
        float beginy = transform.position.y;


        if (Input.GetKeyDown(KeyCode.A))
        {
            dis = (Vector2)transform.position + Vector2.left;
            tweener.AddTween(item.transform, item.transform.position, new Vector2(beginX - 1, beginy), 0.1f);
            moving.Play();
        }
            

        if (Input.GetKeyDown(KeyCode.D))
        {
            dis = (Vector2)transform.position + Vector2.right;
            tweener.AddTween(item.transform, item.transform.position, new Vector2(beginX + 1, beginy), 0.1f);
            moving.Play();
        }



        if (Input.GetKeyDown(KeyCode.S))
        {
            dis = (Vector2)transform.position + Vector2.down;
            tweener.AddTween(item.transform, item.transform.position, new Vector2(beginX, beginy - 1), 0.1f);
            moving.Play();
        }



        if (Input.GetKeyDown(KeyCode.W))
        {
            dis = (Vector2)transform.position + Vector2.up;
            tweener.AddTween(item.transform, item.transform.position, new Vector2(beginX, beginy + 1), 0.1f);
            moving.Play();
        }
            

        //Pac animation
        Vector2 direction = dis - (Vector2)transform.position;
        GetComponent<Animator>().SetFloat("DirX", direction.x);
        GetComponent<Animator>().SetFloat("DirY", direction.y);
        
    }

    void lastInput()
    {

    }

}
