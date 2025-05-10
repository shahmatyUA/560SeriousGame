using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TowerDefense.Towers;

public class GenerateQuestionLvl1 : MonoBehaviour
{
    public CodeChallengeData[] codeChallengeDatas;
    public GameObject QuestionUI;
    public GameObject MainUI;

    public Tutorial tutorial;

    private CodeChallengeUI codeChallengeUI;
    private int i = 0;

    public Tower currentTower;

    // Start is called before the first frame update
    void Start()
    {
        if (codeChallengeDatas.Length == 0)
        {
            Debug.LogError("CodeChallengeDatas array is empty!");

        }
        else { 
            Shuffle();
        }

        codeChallengeUI = GetComponent<CodeChallengeUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateQuestion(Tower curTower)
    {
        currentTower = curTower;
        codeChallengeUI.LoadChallenge(codeChallengeDatas[i]);
        i++;
        if (i >= codeChallengeDatas.Length)
        {
            i = 0; // reset just to make sure no index errors
            Shuffle(); 
        }

        QuestionUI.SetActive(true);
        MainUI.SetActive(false);
    }

    public void AnswerQuestion()
    {
        if (codeChallengeUI.isCorrect)
        {
            Debug.Log("Correct!");
            currentTower.isDisabled = false;
            currentTower.currentTowerLevel.SetAffectorState(true);
            currentTower.GetComponent<ParticleTower>().myParticles.Stop();

            tutorial.done = true;
        }
        else
        {
            Debug.Log("Incorrect.");
            //StartCoroutine(WaitForTowerEnable(2f));
            // TODO add some effect to show that they did indeed fail
        }

        QuestionUI.SetActive(false);
        MainUI.SetActive(true);
    }

    // randomize the order of the questions
    private void Shuffle()
    {
        for (int i = 0; i < codeChallengeDatas.Length; i++)
        {
            int randomIndex = Random.Range(i, codeChallengeDatas.Length);
            CodeChallengeData temp = codeChallengeDatas[i];
            codeChallengeDatas[i] = codeChallengeDatas[randomIndex];
            codeChallengeDatas[randomIndex] = temp;
        }
    }

    IEnumerator WaitForTowerEnable(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        currentTower.isDisabled = false;
    }
}
