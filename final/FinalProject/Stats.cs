using System;
using System.Xml.Serialization;

public class Stats
{
    private int _health;
    private int _attack;
    private int _defense;
    private int _speed;
    private int _specialAttack;
    private int _specialDefense;
    private int _accuracy;
    private int _total;

    public Stats(int attack, int defense, int speed, int specialAttack, int specialDefense, int accuracy)
    {
        _attack=attack;
        _defense=defense;
        _speed=speed;
        _specialAttack=specialAttack;
        _specialDefense=specialDefense;
        _accuracy=accuracy;
        _total=0;
    }


    public void SetHealth(int health)
    {
        _health = health;
    }

    public void AddTotal()
    {
        _total=_accuracy+_attack+_defense+_health+_specialAttack+_specialDefense+_speed;
    }

    public void GetStatInfo()
    {
        Console.WriteLine($"Health:{_health} / Attack:{_attack} / Defense:{_defense} / Speed:{_speed} / Special Attack:{_specialAttack} / Special Defense:{_specialDefense} / Total:{_total}");
    }

    public int GetTotal()
    {
        return _total;
    }
}