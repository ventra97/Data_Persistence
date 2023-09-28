using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Button jugarBtn;
    [SerializeField] TMP_InputField nombreInput;

    public string nombre;
    public static MenuManager Instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 
    public void StartNew()
    {
        nombre = nombreInput.text;
        if (nombre != "")
        {
            print("El nombre es " + nombre);
            SceneManager.LoadScene(1);
        }
        else
        {
            print("El nombre está vacío");
        }
        
    }
}
