using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainScript : MonoBehaviour
{
    [SerializeField] InputField _nameIf, _passwordIf;
    [SerializeField] Text _baslikText;

    PasswordControl _passworldc = new PasswordControl();
  
    public void ButtonControl()
    {
       // _passworldc.Name = "adem";
       // _passworldc.Password1 = "ertas";
        if (_nameIf.text == _passworldc.Name && _passwordIf.text==_passworldc.Password1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        else
        {
            _baslikText.text = "yanlıs! 'adem ertas' dene";
        }
    }
    public void TextKontrol()
    {
        if (_nameIf.text.Length > 6)
        {
            Debug.Log("İsminiz Altı Haneden Buyuk Olamaz!!!");
        }
        if (_passwordIf.text.Length > 6)
        {
            Debug.Log("Parolaniz Altı Haneden Buyuk Olamaz!!!");
        }
    }
}
