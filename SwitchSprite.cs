using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class SwitchSprite : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite[] folding;
    public GameObject clothing3D;
    public GameObject clothingFolded;
    public Vector3 Newplace;

    void Start()
    {
        spriteRenderer.sprite = folding[0];
    }

    void Update()
    {

    }
    public void first()
    {
        if (spriteRenderer.sprite == folding[0])
        {
            spriteRenderer.sprite = folding[1];
        }
    }
    public void Second()
    {
        if (spriteRenderer.sprite == folding[1])
        {
            spriteRenderer.sprite = folding[2];
        }
    }
    public void thrid()
    {
        if (spriteRenderer.sprite == folding[2])
        {
            spriteRenderer.sprite = folding[3];
        }
    }
    public void forth()
    {
        if (spriteRenderer.sprite == folding[3])
        {
            if (CompareTag("Hoodie"))
            {
                spriteRenderer.sprite = folding[4];
            }
            else
            {
                gameObject.SetActive(false);
                clothing3D.transform.position = Newplace;
                clothingFolded.SetActive(true);

            }
        }
    }
    public void fives()
        {
            if (spriteRenderer.sprite == folding[4] && this.CompareTag("Hoodie"))
            {
                gameObject.SetActive(false);
                clothing3D.transform.position = Newplace;
                clothingFolded.SetActive(true);
            }
        }

    }

