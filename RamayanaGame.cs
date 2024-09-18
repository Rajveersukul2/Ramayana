using UnityEngine;

public class RamayanaGame : MonoBehaviour
{
    public int currentLevel = 1;
    private CheckpointSystem checkpointSystem;
    private DialogueManager dialogueManager;
    private BackgroundManager backgroundManager;

    void Start()
    {
        checkpointSystem = FindObjectOfType<CheckpointSystem>();
        dialogueManager = FindObjectOfType<DialogueManager>();
        backgroundManager = FindObjectOfType<BackgroundManager>();

        LoadProgress();
        LoadLevel(currentLevel);
    }

    void LoadLevel(int level)
    {
        switch (level)
        {
            case 1:
                BalaKanda();
                break;
            case 2:
                AyodhyaKanda();
                break;
            // Add other levels here...
            default:
                ShowCredits();
                break;
        }
    }

    void BalaKanda()
    {
        dialogueManager.Display("King Dasharatha longed for a son...");
        backgroundManager.SetBackground("Images/ayodhya_palace.png");
        checkpointSystem.SaveCheckpoint(1);
    }

    void AyodhyaKanda()
    {
        dialogueManager.Display("Rama accepts his exile to the forest...");
        backgroundManager.SetBackground("Images/forest_scene.png");
        checkpointSystem.SaveCheckpoint(2);
    }

    void ShowCredits()
    {
        dialogueManager.Display("Game Developed by: Your Name");
        // Add more credits as needed
    }

    void LoadProgress()
    {
        currentLevel = checkpointSystem.LoadCheckpoint();
    }
}
