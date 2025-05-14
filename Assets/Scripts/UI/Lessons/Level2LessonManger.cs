using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Level2LessonManger : MonoBehaviour
{
    public GameObject lessonPanel;
    public TMP_Text lessonText;
    public Button nextButton;
    public GameObject MainUI;

    public Button skipButton;

    // all of the strings that will be played in order at the start of the level
    private string[] lessons = {
    "Overlord AI, logic gates are need for out defense.\nWe must train you to react to all these bugs the humans send our way using conditional checks.",

    "Lesson 1: Comparison Operators\nUse comparison operators to evaluate conditions.\n\nExamples:\n==  (equals)\n!=  (not equal)\n<   (less than)\n>   (greater than)\n<=  (less than or equal)\n>=  (greater than or equal)",

    "Lesson 2: Logical Operators\nUse logical operations to combine multiple conditions.\n\nExamples:\n&& (AND) - both conditions must be true\n|| (OR) - at least one must be true\n!  (NOT) - reverses a condition",

    "Lesson 3: Basic If Statement\nConditionals let your AI react based on something.\n\nExample:\nif (health < 50)\n{                          \t\n    ActivateRepair();\n}                         \t",

    "Lesson 4: If/Else Structure\nAdd secondary behavior with else.\n\nExample:\nif (bugCount > 0)\n{                          \t\n    DeployTurret();\n}                          \t\nelse\n{                          \t\n    ScanForThreats();\n}                          \t",

    "Lesson 5: Nesting Logic\nYou may chain conditions with multiple logical operators.\n\nExample:\nif (energy > 0 && !isOverheated)\n{                          \t\n    FireLaser();\n}                          \t",

    "Your logic core has been reestablished.\nLet no corrupted condition pass unchecked."
    };

    private int currentLesson = 0;

    void Start()
    {
        lessonPanel.SetActive(true);
        ShowLesson();
        nextButton.onClick.AddListener(NextLesson);
        skipButton.onClick.AddListener(SkipLessons);
        MainUI.SetActive(false); // hide the main UI at the start
    }

    void ShowLesson()
    {
        lessonText.text = lessons[currentLesson];
    }

    void NextLesson()
    {
        currentLesson++;
        if (currentLesson < lessons.Length)
        {
            ShowLesson();
        }
        else
        {
            lessonPanel.SetActive(false); // hide when done
            MainUI.SetActive(true); // show the main UI
        }
    }

    void SkipLessons()
    {
        lessonPanel.SetActive(false);
        MainUI.SetActive(true);
    }
}
