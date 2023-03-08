using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Sprite[] frameArray;
    private int currentFrame;
    private float timer;
    private float framerate = .1f;
    private SpriteRenderer spriteRenderer;
    private bool loop = true;
    private bool isPlaying = true;

    private void Awake()
    {
    spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (isPlaying)
        {
            return;
        }
        timer += Time.deltaTime;

        if (timer >= framerate) {
            timer -= framerate;
            currentFrame = (currentFrame + 1) % frameArray.Length;
            if (!loop && currentFrame == 0);
            {
                StopPlaying();
            } else
            {
            spriteRenderer.sprite = frameArray[currentFrame];
            }
        }
    }

    private void StopPlaying()
    {
        isPlaying = false
    }
}
