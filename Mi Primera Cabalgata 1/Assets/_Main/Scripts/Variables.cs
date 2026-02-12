using UnityEngine;
using TMPro;

public class Variables : MonoBehaviour
{
    //Declarar Variables

    public string myName = "Salomón";
    public int edad = 17;

    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TMP_Text _saludo; 

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        myName = _inputField.text;
        _saludo.text = "Hola " + myName;
    }
}

