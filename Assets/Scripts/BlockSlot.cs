using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CodeChallenge/BlockSlot")]
public class BlockSlot : MonoBehaviour
{
    public string correctAnswer; // What block goes here
    public bool isRequired = false; // Optional challenge mechanic: if false, player can leave empty
}
