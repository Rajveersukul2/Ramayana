using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public SpriteRenderer backgroundRenderer;

    public void SetBackground(string imagePath)
    {
        Sprite background = Resources.Load<Sprite>(imagePath);
        if (background != null)
        {
            backgroundRenderer.sprite = background;
        }
        else
        {
            Debug.LogError("Background image not found: " + imagePath);
        }
    }
}
