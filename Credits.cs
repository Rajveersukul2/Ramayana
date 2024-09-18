using UnityEngine;

public class Credits : MonoBehaviour
{
    public DialogueManager dialogueManager;

    public void ShowCredits()
    {
        dialogueManager.Display("Game Developed by: Rajveer Sukul");
        dialogueManager.Display("Story Adaptation: Ancient Scriptures");
        dialogueManager.Display("Music by: Chat gpt");
        dialogueManager.Display("Special Thanks to:Chat gpt");
    }
}
