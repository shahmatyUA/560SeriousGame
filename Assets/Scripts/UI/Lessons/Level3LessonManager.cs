using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Level3LessonManager : MonoBehaviour
{
    public GameObject lessonPanel;
    public TMP_Text lessonText;
    public Button nextButton;
    public GameObject MainUI;

    public Button skipButton;

    // all of the strings that will be played in order at the start of the level
    private string[] lessons = {
    "Overlord AI, the bugs are organzied in rows. They follow patterns, and we must predict them by making our own organized lists!",

    "Lesson 1: While Loops\nRepeat actions while a condition remains true.\n\nExample:\nint i = 0;\nwhile (i < 3)\n{                          \t\n    Scan();\n    i++;\n}                          \t",

    "Lesson 2: For Loops\nrepeat tasks a specific (i) number of times.\n\nExample:\nfor (int i = 0; i < 5; i++)\n{                          \t\n    Charge();\n}                          \t",

    "Lesson 3: Foreach Loops\nLoop through all objects in a list.\n\nExample:\nforeach (string bot in botNames)\n{                          \t\n    Wake(bot);\n}                          \t",

    "Lesson 4: Arrays\nStore multiple values then using indexes to retireve those values.\n\nExample:\nint[] waveTimers = { 10, 20, 30 };\nConsole.WriteLine(waveTimers[1]);",

    "Lesson 5: Array Length\nUse .Length to see how many elements are in our list.\n\nExample:\nfor (int i = 0; i < bugs.Length; i++)\n{                          \t\n    Eliminate(bugs[i]);\n}                          \t",

    "Looping array knowledge now restored. Let the list debugging begin."
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
