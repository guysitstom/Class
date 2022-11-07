using System;

public class Character
{
    string characterName;
    int maxHP;
    bool isPlayer;
    public Character(string _charactername, int _maxHP, bool _isPlayer)
    {
    
        characterName = _charactername;
        maxHP = _maxHP;
        isPlayer = _isPlayer;

        
    }
    public void Attack(Character victim)
    {
        victim.maxHP-= 5;
        this.maxHP--;
    }
}