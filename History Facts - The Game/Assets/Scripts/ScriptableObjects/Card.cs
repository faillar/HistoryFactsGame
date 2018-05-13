using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card",menuName = "Card")]
public class Card : ScriptableObject {

    public Sprite image;
    public int age;
    public new string name;

    public GameObject diorama;
}
