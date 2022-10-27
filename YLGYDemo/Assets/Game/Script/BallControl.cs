using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BallControl : MonoBehaviour
{
    [SerializeField] Sprite newSprite;

    public void Restore()
    {
        //transform.position = new Vector3(0, 0, 0);
        //transform.eulerAngles = new Vector3(0, 0, 0);
        transform.DOMove(new Vector2(0, 0), 0);
        transform.DORotate(new Vector3(0, 0, 0), 0);
        GetComponent<SpriteRenderer>().DOFade(1, 0);
    }

    public void Move()
    {
        transform.DOMoveY(5, 2);
    }

    public void Fade()
    {
        GetComponent<SpriteRenderer>().DOFade(0, 2);
    }

    public void MoveAndRotateInParallel()
    {
        transform.DOMove(new Vector2(5, 5), 2);
        transform.DORotate(new Vector3(0, 0, 180), 2);
    }

    public void MoveAndRotateInSequence()
    {
        Sequence mySequence = DOTween.Sequence();
        mySequence.Append(transform.DOMove(new Vector2(5, 5), 2)).Append(transform.DORotate(new Vector3(0, 0, 180), 2));
    }

    public void MoveUpAndDown()
    {
        Sequence mySequence = DOTween.Sequence();
        mySequence.Append(transform.DOMoveY(-5, 2).SetEase(Ease.InOutSine)).Append(transform.DOMoveY(5, 2).SetEase(Ease.InOutSine).SetLoops(5, LoopType.Yoyo));
        //transform.DOMoveY(5, 2).SetEase(Ease.InOutSine).SetLoops(5, LoopType.Yoyo);
    }

    public void MoveAndChangeImage()
    {
        transform.DOMove(new Vector2(3, 3), 2).OnComplete(ChangeImage);
        //transform.DOMove(new Vector2(3, 3), 2).onComplete([ChangeImage]);
    }

    private void ChangeImage()
    {
        GetComponent<SpriteRenderer>().sprite = newSprite;
    }
}
