using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CodeChallenge/ChallengeData")]
public class CodeChallengeData : ScriptableObject
{
    //public string challengeID;
    [TextArea] public string prompt;
    [TextArea] public string code;
    public string[] codeBlockOptions;
    public int correctAnswerIndex;

    public bool IsCorrectAnswer(int selectedIndex)
    {
        return selectedIndex == correctAnswerIndex;
    }

    public string GetCodeWithAnswer(int selectedIndex)
    {
        return code.Replace("[code here]", codeBlockOptions[selectedIndex]);
    }
}
