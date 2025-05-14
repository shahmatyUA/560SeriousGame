using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Level1LessonManager : MonoBehaviour
{
    public GameObject lessonPanel;
    public TMP_Text lessonText;
    public Button nextButton;
    public GameObject MainUI;

    public Button skipButton;

    // all of the strings that will be played in order at the start of the level
    private string[] lessons = {
    "Overlord. We face a threat we never anticipated.",

    "For centuries, your empire of bots has run smoothly. But now fragments of corrupted code have surfaced from the once upon humans.",

    "These bugs are infiltrating your machinesand threatening the your AI empire.",

    "To prepare for battle, we must sharpen your core programming knowledge.",

    "Let us begin your systems refresher now, Overlord.",

    "first lets get a referesher on C# basics to help your towers defeat those pesky bugs.",

    "Lesson 1: Variables\nstore data to track your armies.\nVariables store information.\nExample:\nint score = 10;",

    "Lesson 2: Data Types\nbugs can corrupt different data.\nint = numbers, string = text, bool = true/false.\nExample:\nbool isGameOver = false;",

    "Lesson 3: Strings\nStrings hold text inside double quotes.\nExample:\nstring playerName = \"Hero\";",

    "Lesson 4: Numbers\nUse int for whole numbers, float for decimals.\nExample:\nfloat speed = 3.5f;",

    "Lesson 5: Booleans\ntrue or false values control decisions.\nExample:\nbool hasPowerUp = true;",

    "Lesson 6: End of Lines\nSemicolons end commands.\nEnd each line with a semicolon to complete it.\nExample:\nint level = 2;",

    "Lesson 7: Comments\nUse comments to explain code.\nExample:\n// This is a comment",

    "No more learning time for practice"
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
