using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class CodeChallengeUI : MonoBehaviour
{
    public CodeChallengeData TestQuestion;

    public Transform codeBlockContainer;
    public GameObject codeBlockPrefab;
    public TMP_Text promptText;
    public TMP_Text codeText;

    public Button[] answerButtons;

    private CodeChallengeData currentQuestion;

    public bool isCorrect = false;

    void Start()
    {
        LoadChallenge(TestQuestion);
    }

    // update all the UI data with our scriptabl object
    public void LoadChallenge(CodeChallengeData data)
    {
        currentQuestion = data;

        //ClearUI();

        if (promptText != null)
            promptText.text = data.prompt;
        if (codeText != null)
            codeText.text = data.code;


        for (int i = 0; i < answerButtons.Length; i++)
        {
            int index = i; 
            answerButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = currentQuestion.codeBlockOptions[i];
            answerButtons[i].onClick.RemoveAllListeners();
            answerButtons[i].onClick.AddListener(() => OnAnswerSelected(index));
        }
    }

    public void OnAnswerSelected(int selectedIndex)
    {
        string updatedCode = currentQuestion.GetCodeWithAnswer(selectedIndex);
        codeText.text = updatedCode;

        isCorrect = currentQuestion.IsCorrectAnswer(selectedIndex);
        //Debug.Log(isCorrect ? "Correct!" : "Incorrect.");
    }

    private void ClearUI()
    {
        foreach (Transform child in codeBlockContainer) Destroy(child.gameObject);
    }

    public bool CheckSolution()
    {
        return false;
    }
}
