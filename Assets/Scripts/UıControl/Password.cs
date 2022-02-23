using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Password 
{


    private string _name="adem";
    
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    private string _password1="ertas";

    public string Password1
    {
        get { return _password1; }
        set { _password1 =value; }
    }


}
