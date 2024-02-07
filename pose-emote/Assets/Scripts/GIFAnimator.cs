using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GIFAnimator : MonoBehaviour
{
    public Image imageComponent; // The UI Image component to display the GIF frames
    public Sprite[] frames; // The GIF frames
    public float fps = 10.0f; // Frames per second for the GIF animation

    private void Start()
    {
        StartCoroutine(PlayGIF());
    }

    IEnumerator PlayGIF()
    {
        int frameCount = frames.Length;
        while (true)
        {
            for (int i = 0; i < frameCount; i++)
            {
                imageComponent.sprite = frames[i];
                yield return new WaitForSeconds(1.0f / fps);
            }
        }
    }
}