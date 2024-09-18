using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText; // Assign via Inspector
    public float typingSpeed = 0.05f;

    private string fullText;
    private bool isTyping = false;

    public void Display(string text)
    {
        if (isTyping)
            return;

        StopAllCoroutines();
        StartCoroutine(TypeSentence(text));
    }

    IEnumerator TypeSentence(string sentence)
    {
        isTyping = true;
        fullText = "";
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            fullText += letter;
            dialogueText.text = fullText;
            yield return new WaitForSeconds(typingSpeed);
        }
        isTyping = false;
    }
}
