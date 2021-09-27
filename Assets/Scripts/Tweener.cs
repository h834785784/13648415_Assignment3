using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{

    private Tween activeTween;



    void Update()
    {

        if (activeTween != null)
        {


            if (Vector3.Distance(activeTween.Target.position, activeTween.Destin) > 0.1f)
            {

                activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.Destin, (Time.time - activeTween.StartTime) / activeTween.Duration);
               
            }

            if (Vector3.Distance(activeTween.Target.position, activeTween.Destin) <= 0.1f)
            {
                activeTween.Target.position = activeTween.Destin;
                activeTween = null;
            }

        }

    }

    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (activeTween == null)
        {
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);

        }

    }


}

