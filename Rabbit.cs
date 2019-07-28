using System;
using System.Collections;
using VampireRabbitsCS;

namespace VampireRabbitsCS
{
public class Rabbit 
{
    private readonly string[] names = new string[]
    {
        "Susan", "Bob", "Rob", "Adelle"
    };
    private readonly string[] colors = new string[]
    {
        "white", "brown", "black"
    };
    private string _name;
    private int _age;
    private bool _isVampire;
    private readonly string _color;
    public string Name
    {
        get{return _name;}
        set{_name=value;}
    }
    public int Age
    {
        get{return _age;}
        set{_age=value;}
    }
    public bool IsVampire{
        get{return _isVampire;}
        set{_isVampire=value;}
    }
    public string Color{
        get{return _color;}
    }
    
    public Rabbit()
    {
        _age = 0;
        _isVampire = false;
        _color = colors[RandomNumberGenerator.SimpleRandomNumber(0, colors.Length)];
        _name = names[RandomNumberGenerator.SimpleRandomNumber(0, names.Length)];
      
    }


}
}