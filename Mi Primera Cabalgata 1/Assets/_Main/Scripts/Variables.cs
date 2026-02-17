using UnityEngine;
using TMPro;

public class Variables : MonoBehaviour
{
    //Declarar Variables

    public string myName = "Salomón";
    public int edad = 17;
    public bool isBool; 

    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TMP_Text _saludo;
    [SerializeField] private Renderer _cubo;
    [SerializeField] private BoxCollider _boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        _boxCollider.isTrigger = false;
        _cubo.material.color = Color.magenta;
    }

    // Update is called once per frame
    void Update()
    {
        myName = _inputField.text;
        _saludo.text = "Hola " + myName;
    }
}

