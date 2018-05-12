using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

    public Card card;

    public Image image;

    public Text ageText;
    public Text nameText;
    public GameObject dioramaObject;

    private Vector3 pos;

    // Use this for initialization
    void Start () {
        nameText.text = card.name;
        ageText.text = card.age.ToString();
        image.sprite = card.image;
        
        //Ahora cambiamos el diorama por el correspondiente de cada carta (pero antes guardamos la posicion para poderlo instanciar en el mismo sitio)
        pos = dioramaObject.transform.position;
        dioramaObject = card.diorama;
        Instantiate(dioramaObject).transform.position = pos;
        dioramaObject.SetActive(false);
    }
}
